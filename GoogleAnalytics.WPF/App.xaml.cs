using System.Windows;

namespace GoogleAnalytics.WPF
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Tracker Tracker { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            AnalyticsManager.Current.IsSecure = false;
            Tracker = AnalyticsManager.Current.CreateTracker("UA-146578159-1");
            Tracker.ClientId = "GAnalytics-Testing-WPF";
            AnalyticsManager.Current.ReportUncaughtExceptions = true;
            // When set to true, the debug api of GA is hit
            // Note: Debug api of GA does not log to the GA console.
            // Set it to false to log the activity.
            //AnalyticsManager.Current.IsDebug = true;

            base.OnStartup(e);
        }
    }
}
