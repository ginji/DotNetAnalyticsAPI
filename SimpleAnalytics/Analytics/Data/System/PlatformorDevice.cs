
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class PlatformorDevice
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("The names of browsers used by visitors to your website. For example, Internet Explorer or Firefox.")]
            public static DataItem browser = new DataItem("browser");
                                      
            [DescriptionAttribute("The browser versions used by visitors to your website. For example, 2.0.0.14")]
            public static DataItem browserVersion = new DataItem("browserVersion");
                                      
            [DescriptionAttribute("The operating system used by your visitors. For example, Windows, Linux , Macintosh, iPhone, iPod.")]
            public static DataItem operatingSystem = new DataItem("operatingSystem");
                                      
            [DescriptionAttribute("The version of the operating system used by your visitors, such as XP for Windows or PPC for Macintosh.")]
            public static DataItem operatingSystemVersion = new DataItem("operatingSystemVersion");
                                      
            [DescriptionAttribute("Mobile manufacturer or branded name.")]
            public static DataItem mobileDeviceBranding = new DataItem("mobileDeviceBranding");
                                      
            [DescriptionAttribute("Mobile device model")]
            public static DataItem mobileDeviceModel = new DataItem("mobileDeviceModel");
                                      
            [DescriptionAttribute("Selector used on the mobile device (e.g.: touchscreen, joystick, clickwheel, stylus).")]
            public static DataItem mobileInputSelector = new DataItem("mobileInputSelector");
                                      
            [DescriptionAttribute("The branding, model, and marketing name used to identify the mobile device.")]
            public static DataItem mobileDeviceInfo = new DataItem("mobileDeviceInfo");
                                      
            [DescriptionAttribute("The marketing name used for the mobile device.")]
            public static DataItem mobileDeviceMarketingName = new DataItem("mobileDeviceMarketingName");
                                      
            [DescriptionAttribute("The type of device: desktop, tablet, or mobile.")]
            public static DataItem deviceCategory = new DataItem("deviceCategory");
                                      
        }

        public sealed class Metrics
        {
            

            public sealed class Calculated
            {
                
            }
        }
    }
}
