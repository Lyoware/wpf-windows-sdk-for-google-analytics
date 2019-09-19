using System;
using GoogleAnalytics;

namespace GoogleAnalytics.WPF
{
    public class PlatformInfoProvider : IPlatformInfoProvider
    {
        Dimensions? viewPortResolution;
        Dimensions? screenResolution;

        #region [Properties]
        public string AnonymousClientId { get; set; }
        public string UserLanguage { get; set; }
        public string UserAgent { get; set; }
        public int? ScreenColors { get; set; }

        public Dimensions? ScreenResolution
        {
            get { return screenResolution; }
            set
            {
                screenResolution = value;
                ScreenResolutionChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public Dimensions? ViewPortResolution
        {
            get { return viewPortResolution; }
            set
            {
                viewPortResolution = value;
                ViewPortResolutionChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        #endregion [Properties]

        #region [Events]
        public event EventHandler Tracking;
        public event EventHandler ViewPortResolutionChanged;
        public event EventHandler ScreenResolutionChanged;
        #endregion [Events]

        public PlatformInfoProvider()
        {
            AnonymousClientId = string.Empty;
            UserLanguage = "es-mx";
            UserAgent = string.Empty;
        }

        #region[Methods]
        public void OnTracking()
        {
            Tracking?.Invoke(this, EventArgs.Empty);
        }
        #endregion


    }
}
