using GoogleAnalytics;
using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace GoogleAnalytics.WPF
{
    public class AnalyticsManager : TrackerManager
    {
        static AnalyticsManager current;
        bool reportUncaughtExceptions;
        Application application;
        /// <summary>
        /// Shared, singleton instance of AnalyticsManager 
        /// </summary>
        public static AnalyticsManager Current
        {
            get
            {
                if (current == null)
                {
                    current = new AnalyticsManager(Application.Current);
                }
                return current;
            }
        }
        AnalyticsManager(Application application) : base(new PlatformInfoProvider())
        {
            this.application = application;
        }

        public AnalyticsManager(IPlatformInfoProvider platformInfoProvider) : base(platformInfoProvider)
        {
            this.application = Application.Current;
        }

        /// <summary>
        /// Creates a new Tracker using a given property ID. 
        /// </summary>
        /// <param name="propertyId">The property ID that the <see cref="Tracker"/> should log to.</param>
        /// <returns>The new or existing instance keyed on the property ID.</returns>
        public override Tracker CreateTracker(string propertyId)
        {
            var tracker = base.CreateTracker(propertyId);
            tracker.AppName = Assembly.GetExecutingAssembly().FullName;
            tracker.AppVersion = $"{Assembly.GetExecutingAssembly().GetName().Version}";
            tracker.ClientId = "";
            return tracker;
        }

        /// <summary>
        /// Enables (when set to true) automatic catching and tracking of Unhandled Exceptions.
        /// </summary>
        public bool ReportUncaughtExceptions
        {
            get
            {
                return reportUncaughtExceptions;
            }
            set
            {
                if (reportUncaughtExceptions != value)
                {
                    reportUncaughtExceptions = value;
                    if (reportUncaughtExceptions)
                    {
                        TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;
                        AppDomain.CurrentDomain.UnhandledException += Application_UnhandledErrorDetected;
                    }
                    else
                    {
                        TaskScheduler.UnobservedTaskException -= TaskScheduler_UnobservedTaskException;
                        AppDomain.CurrentDomain.UnhandledException -= Application_UnhandledErrorDetected;
                    }
                }
            }
        }


        void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            var ex = e.Exception.InnerException ?? e.Exception; // inner exception contains better info for unobserved tasks
            foreach (var tracker in Trackers)
            {
                tracker.Send(HitBuilder.CreateException(ex.ToString(), false).Build());
            }
        }

        void Application_UnhandledErrorDetected(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                if (e.IsTerminating)
                {
                    //Now is a good time to write that critical error file!
                    MessageBox.Show("Goodbye world!");
                }
            }
            catch (Exception ex)
            {
                foreach (var tracker in Trackers)
                {
                    tracker.Send(HitBuilder.CreateException(ex.Message, true).Build());
                }
                var t = DispatchAsync();
                throw;
            }
        }
    }
}
