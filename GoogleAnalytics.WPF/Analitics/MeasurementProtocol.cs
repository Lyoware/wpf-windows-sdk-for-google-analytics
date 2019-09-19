using System.ComponentModel;

namespace GoogleAnalytics.WPF
{
    public class ParameterNames
    {
        //General 
        public const string Version = "v";      // required 
        public const string PropertyId = "tid"; // required 
        public const string AnonymizeId = "aid";
        public const string DataSource = "ds";
        public const string CacheBuster = "z";
        public const string QueueTime = "qt";

        //User
        public const string ClientId = "cid";   // required if userId is not included. 
        public const string UserId = "uid";     // required if ClientId is not included;  

        //Session 
        public const string SessionControl = "sc"; // 'start' , 'end' ; 
        public const string IPOverride = "uip";
        public const string UserAgentOverride = "ua";
        public const string GeographicOverride = "geoid";

        //Traffic Sources 
        public const string Referrer = "dr";
        public const string CampaignName = "cn";
        public const string CampaignSource = "cs";
        public const string CampaignMedium = "cm";
        public const string CampaignKeyword = "ck";
        public const string CampaignContent = "cc";
        public const string CampaignId = "ci";
        public const string GoogleAdwordsId = "gclid";      //unused 
        public const string GoogleDisplayAdsId = "dclid";   // unused 

        //System Info 
        public const string ScreenResolution = "sr";
        public const string ViewportSize = "vp";
        public const string Encoding = "de";
        public const string ScreenColors = "sd";
        public const string UserLanguage = "ul";
        public const string JavaEnabled = "je";  // unused 
        public const string FlashVersion = "fl";  //unused 

        //Hit  
        public const string HitType = "t";
        public const string NonInteractionHit = "ni";  //unused 

        //Content Information 
        public const string DocumentLocation = "dl";
        public const string DocumentHostName = "dh";
        public const string DocumentPath = "dp";
        public const string DocumentTitle = "dt";
        public const string ScreenName = "cd";   // required for screenview hit type 
        public const string ContentGroup = "cg{index}";
        public const string LinkId = "linkid";


        // App Tracking 
        public const string AppName = "an";
        public const string AppId = "aid";
        public const string AppVersion = "av";
        public const string AppInstallerId = "aiid";

        //Event tracking 
        public const string EventCategory = "ec"; // required for event hit type 
        public const string EventAction = "ea";  // required for event hit type 
        public const string EventLabel = "el";
        public const string EventValue = "ev";

        //ECommerce 
        public const string TransactionId = "ti"; //required for transaction type or item hit type 
        public const string TransactionAffiliation = "ta";
        public const string TransactionRevenue = "tr";
        public const string TransactionShipping = "ts";
        public const string TransactionTax = "tt";

        public const string ItemName = "in"; // required for item hit type 
        public const string ItemPrice = "ip";
        public const string ItemQuantity = "iq";
        public const string ItemCode = "ic";
        public const string ItemCategory = "iv";

        // Enhanced Commerce 
        public const string ProductSKU = "pr{productIndex}id";
        public const string ProductName = "pr{productIndex}nm";
        public const string ProductBrand = "pr{productIndex}br";
        public const string ProductCategory = "pr{productIndex}ca";
        public const string ProductVariant = "pr{productIndex}va";
        public const string ProductPrice = "pr{productIndex}pr";
        public const string ProductQuantity = "pr{productIndex}qt";
        public const string ProductCouponCode = "pr{productIndex}cc";
        public const string ProductPosition = "pr{productIndex}ps";
        public const string ProductDimension = "pr{productIndex}cd{dimensionIndex}";
        public const string ProductMetric = "pr{productIndex}cm{metricIndex}";

        public const string ProductAction = "pa";
        public const string ProductActionTransactionId = "ti";  // same as TransactionId 
        public const string ProductActionAffiliation = "ta";
        public const string ProductActionRevenue = "tr";
        public const string ProductActionTax = "tt";
        public const string ProductActionShipping = "ts";
        public const string ProductActionCouponCode = "tcc";
        public const string ProductActionList = "pal";
        public const string ProductActionCheckoutStep = "cos";
        public const string ProductActionCheckoutStepOption = "col";
        public const string ProductImpressionListName = "il{listIndex}nm";
        public const string ProductImpressionSKU = "il{listIndex}pi{productIndex}id";
        public const string ProductImpressionBrand = "il{listIndex}pi{productIndex}id";
        public const string ProductImpressionCategory = "il{listIndex}pi{productIndex}id";
        public const string ProductImpressionVariant = "il{listIndex}pi{productIndex}va";
        public const string ProductImpressionPosition = "il{listIndex}pi{productIndex}ps";
        public const string ProductImpressionPrice = "il{listIndex}pi{productIndex}pr";
        public const string ProductImpressionDimension = "il{listIndex}pi{productIndex}cd{dimensionIndex}";
        public const string ProductImpressionMetric = "il{listIndex}pi{productIndex}cm{dimensionIndex}";

        public const string PromotionId = "promo{promoIndex}id";
        public const string PromotionName = "promo{promoIndex}nm";
        public const string PromotionCreative = "promo{promoIndex}cr";
        public const string PromotionPosition = "promo{promoIndex}ps";
        public const string PromotionAction = "promoa";
        public const string CurrencyCode = "cu";


        //Social interactions 
        public const string SocialNetwork = "sn";      //required for social hit type 
        public const string SocialAction = "sa";       //required for social hit type 
        public const string SocialActionTarget = "st"; // required for social hit target 

        //Timing 
        public const string TimingCategory = "utc"; // required for timing hit type 
        public const string TimingVariable = "utv"; //required for timing hit type 
        public const string TimingLabel = "utl";
        public const string PageLoadTime = "plt";       // unused 
        public const string DnsLookupTime = "dns";      // unused 
        public const string PageDownloadTime = "pdt";   // unused 
        public const string RedirectTime = "rrt";        // unused 
        public const string TcpConectTime = "tcp";       //unused 
        public const string ServerResponseTime = "srt";  //unused 
        public const string DomInteractiveTime = "dit";  // unused 
        public const string ContentLoadTime = "clt";     // unused 

        //Exceptions 
        public const string ExceptionDescription = "exd";
        public const string ExceptionIsFatal = "exf";


        //Custom dimensions & metrics 
        public const string Dimension = "cd{dimensionIndex}";
        public const string Metric = "cd{metricIndex}";

        //Content experiments 
        public const string ExperimentId = "xid";
        public const string ExperimentVariant = "xvar";

    }
    public struct MeasurementProtocol
    {
        public enum General
        {
            [Description("v")]// required 
            Version,
            [Description("tid")] // required 
            PropertyId,
            [Description("aid")]
            AnonymizeId,
            [Description("ds")]
            DataSource,
            [Description("z")]
            CacheBuster,
            [Description("qt")]
            QueueTime
        }

        public enum User
        {
            [Description("cid")]   // required if userId is not included. 
            ClientId,
            [Description("uid")]     // required if ClientId is not included; 
            UserId
        }


        public enum Session
        {
            [Description("sc")] // 'start' , 'end' ; 
            SessionControl,
            [Description("uip")]
            IPOverride,
            [Description("ua")]
            UserAgentOverride,
            [Description("geoid")]
            GeographicOverride
        }

        public enum TrafficSources
        {
            [Description("dr")]
            Referrer,
            [Description("cn")]
            CampaignName,
            [Description("cs")]
            CampaignSource,
            [Description("cm")]
            CampaignMedium,
            [Description("ck")]
            CampaignKeyword,
            [Description("cc")]
            CampaignContent,
            [Description("ci")]
            CampaignId,
            [Description("gclid")]   //unused 
            GoogleAdwordsId,
            [Description("dclid")]   // unused 
            GoogleDisplayAdsId
        }
        public enum SystemInfo
        {
            [Description("sr")]
            ScreenResolution,
            [Description("vp")]
            ViewportSize,
            [Description("de")]
            Encoding,
            [Description("sd")]
            ScreenColors,
            [Description("ul")]
            UserLanguage,
            [Description("je")]  // unused 
            JavaEnabled,
            [Description("fl")]  //unused 
            FlashVersion
        }
        public enum Hit
        {
            [Description("t")]
            HitType,
            [Description("ni")]  //unused 
            NonInteractionHit
        }



        public enum ContentInformation
        {
            [Description("dl")]
            DocumentLocation,
            [Description("dh")]
            DocumentHostName,
            [Description("dp")]
            DocumentPath,
            [Description("dt")]
            DocumentTitle,
            [Description("cd")]   // required for screenview hit type 
            ScreenName,
            [Description("cg{index}")]
            ContentGroup,
            [Description("linkid")]
            LinkId
        }


        public enum AppTracking
        {
            [Description("an")]
            AppName,
            [Description("aid")]
            AppId,
            [Description("av")]
            AppVersion,
            [Description("aiid")]
            AppInstallerId
        }


        public enum EventTracking
        {
            [Description("ec")] // required for event hit type 
            EventCategory,
            [Description("ea")]  // required for event hit type 
            EventAction,
            [Description("el")]
            EventLabel,
            [Description("ev")]
            EventValue
        }


        public enum ECommerce
        {
            [Description("ti")] //required for transaction type or item hit type 
            TransactionId,
            [Description("ta")]
            TransactionAffiliation,
            [Description("tr")]
            TransactionRevenue,
            [Description("ts")]
            TransactionShipping,
            [Description("tt")]
            TransactionTax,

            [Description("in")] // required for item hit type 
            ItemName,
            [Description("ip")]
            ItemPrice,
            [Description("iq")]
            ItemQuantity,
            [Description("ic")]
            ItemCode,
            [Description("iv")]
            ItemCategory
        }


        public enum EnhancedCommerce
        {
            [Description("p{productInde}id")]
            ProductSKU,
            [Description("p{productInde}nm")]
            ProductName,
            [Description("p{productInde}br")]
            ProductBrand,
            [Description("p{productInde}ca")]
            ProductCategory,
            [Description("p{productInde}va")]
            ProductVariant,
            [Description("p{productInde}pr")]
            ProductPrice,
            [Description("p{productInde}qt")]
            ProductQuantity,
            [Description("p{productInde}cc")]
            ProductCouponCode,
            [Description("p{productInde}ps")]
            ProductPosition,
            [Description("p{productInde}cd{dimensionIndex}")]
            ProductDimension,
            [Description("p{productInde}cm{metricIndex}")]
            ProductMetric,

            [Description("pa")]
            ProductAction,
            [Description("ti")]  // same as TransactionId 
            ProductActionTransactionId,
            [Description("ta")]
            ProductActionAffiliation,
            [Description("tr")]
            ProductActionRevenue,
            [Description("tt")]
            ProductActionTax,
            [Description("ts")]
            ProductActionShipping,
            [Description("tcc")]
            ProductActionCouponCode,
            [Description("pal")]
            ProductActionList,
            [Description("cos")]
            ProductActionCheckoutStep,
            [Description("col")]
            ProductActionCheckoutStepOption,
            [Description("il{listIndex}nm")]
            ProductImpressionListName,
            [Description("il{listIndex}pi{productIndex}id")]
            ProductImpressionSKU,
            [Description("il{listIndex}pi{productIndex}id")]
            ProductImpressionBrand,
            [Description("il{listIndex}pi{productIndex}id")]
            ProductImpressionCategory,
            [Description("il{listIndex}pi{productIndex}va")]
            ProductImpressionVariant,
            [Description("il{listIndex}pi{productIndex}ps")]
            ProductImpressionPosition,
            [Description("il{listIndex}pi{productIndex}pr")]
            ProductImpressionPrice,
            [Description("il{listIndex}pi{productIndex}cd{dimensionIndex}")]
            ProductImpressionDimension,
            [Description("il{listIndex}pi{productIndex}cm{dimensionIndex}")]
            ProductImpressionMetric,

            [Description("prom{promoIndex}id")]
            PromotionId,
            [Description("prom{promoIndex}nm")]
            PromotionName,
            [Description("prom{promoIndex}cr")]
            PromotionCreative,
            [Description("prom{promoIndex}ps")]
            PromotionPosition,
            [Description("promoa")]
            PromotionAction,
            [Description("cu")]
            CurrencyCode
        }


        public enum SocialInteractions
        {
            [Description("sn")]//required for social hit type 
            SocialNetwork,
            [Description("sa")]//required for social hit type 
            SocialAction,
            [Description("st")] // required for social hit target 
            SocialActionTarget

        }

        public enum Timing
        {
            [Description("utc")] // required for timing hit type 
            TimingCategory,
            [Description("utv")] //required for timing hit type 
            TimingVariable,
            [Description("utl")]
            TimingLabel,
            [Description("plt")]       // unused 
            PageLoadTime,
            [Description("dns")]      // unused 
            DnsLookupTime,
            [Description("pdt")]   // unused 
            PageDownloadTime,
            [Description("rrt")]        // unused 
            RedirectTime,
            [Description("tcp")]       //unused 
            TcpConectTime,
            [Description("srt")]  //unused 
            ServerResponseTime,
            [Description("dit")]  // unused 
            DomInteractiveTime,
            [Description("clt")]     // unused 
            ContentLoadTime
        }


        public enum Exceptions
        {
            [Description("exd")]
            ExceptionDescription,
            [Description("exf")]
            ExceptionIsFatal
        }

        public enum CustomDimensionsAndMetrics
        {
            [Description("c{dimensionIndex}")]
            Dimension,
            [Description("c{metricIndex}")]
            Metric
        }
        public enum ContentExperiments
        {
            [Description("xid")]
            ExperimentId,
            [Description("xvar")]
            ExperimentVariant
        }


    }
}
