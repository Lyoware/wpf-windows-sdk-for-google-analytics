using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GoogleAnalytics.WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isRunningInDebugMode;

        public MainWindow()
        {
            App.Tracker.ScreenName = "Main";
            App.Tracker.Page = "MainTestingSDK";
            App.Tracker.Title = "MainPage";
            InitializeComponent();
            isRunningInDebugMode = IsDebugRequest.IsChecked.Value;
            // wire up to event for debugging purposes:
            AnalyticsManager.Current.HitSent += AnalyticsManager_HitSent;
            AnalyticsManager.Current.HitMalformed += AnalyticsManager_HitMalformed;
            AnalyticsManager.Current.HitFailed += AnalyticsManager_HitFailed;
        }
    

        private void AnalyticsManager_HitFailed(object sender, HitFailedEventArgs e)
        {
            Log(e.Hit, $"**Hit Failed** {Environment.NewLine} {e.Error.Message}");

        }

        private void AnalyticsManager_HitMalformed(object sender, HitMalformedEventArgs e)
        {
            Log(e.Hit, $"**Hit Malformed ** {Environment.NewLine} {e.HttpStatusCode.ToString()}");
        }

        private void AnalyticsManager_HitSent(object sender, HitSentEventArgs e)
        {
            Log(e.Hit, e.Response);
        }
        private void ButtonEvent_Click(object sender, RoutedEventArgs e)
        {
            App.Tracker.Send(HitBuilder.CreateCustomEvent("EventoTesting", "userclick", "lab1", 10).Build());
        }

        private void ButtonView_Click(object sender, RoutedEventArgs e)
        {
            App.Tracker.Send(HitBuilder.CreateScreenView("TestingSDK").Build());
        }

        private void ButtonSocial_Click(object sender, RoutedEventArgs e)
        {
            App.Tracker.Send(HitBuilder.CreateSocialInteraction("facebook", "share", "https://www.facebook.com").Build());
        }

        private void ButtonTiming_Click(object sender, RoutedEventArgs e)
        {
            App.Tracker.Send(HitBuilder.CreateTiming("someaction", "loadtime", TimeSpan.FromSeconds(2)).Build());
        }

        private void ButtonException_Click(object sender, RoutedEventArgs e)
        {

            App.Tracker.Send(HitBuilder.CreateException("oops, something went wrong", false).Build());
        }

        private void ButtonThrowException_Click(object sender, RoutedEventArgs e)
        {
            object y = 1;
            string x = (string)y;
        }

        private void IsDebugRequest_Checked(object sender, RoutedEventArgs e)
        {
            isRunningInDebugMode = IsDebugRequest.IsChecked.Value;
            Visibility visibility = isRunningInDebugMode ? Visibility.Visible : Visibility.Collapsed;
            RequestPanel.Visibility = visibility;
            ResponsePanel.Visibility = visibility;
        }
        void Log(Hit hit, string message)
        {
            if (isRunningInDebugMode)
            {
                if (AnalyticsManager.Current.DispatchPeriod > TimeSpan.Zero)
                {
                    message = "Using dispatcher-which batches activity. Here is the last hit sent\n" + message;
                }

                if (Dispatcher.CheckAccess())
                {
                    Results.Text = message;
                    Request.Text = Parse(hit);
                }
                else
                {
                    Dispatcher.InvokeAsync(() =>
                    {
                        Results.Text = message;
                        Request.Text = Parse(hit);
                    });
                }

            }
            //Output to console regardless 
            System.Diagnostics.Debug.WriteLine(message);
        }

        string Parse(Hit hit)
        {
            StringBuilder builder = new StringBuilder();
            if (hit != null)
            {
                foreach (string param in hit.Data.Keys)
                {
                    builder.Append($"{param}:{hit.Data[param]}{Environment.NewLine}");
                }
            }
            return builder.ToString();
        }
    }
}
