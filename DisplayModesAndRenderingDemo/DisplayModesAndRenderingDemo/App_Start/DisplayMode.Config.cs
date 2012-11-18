using System;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using System.Collections.Generic;


namespace DisplayModesAndRenderingDemo
{
    public class DisplayModeConfig
    {
        public static void RegisterDisplayModes(IList<IDisplayMode> modes)
        {       
            modes.Insert(0, new DefaultDisplayMode("android")
            {
                ContextCondition = (context => context.GetOverriddenUserAgent().IndexOf
                  ("Android", StringComparison.OrdinalIgnoreCase) >= 0)
            });
            modes.Insert(1, new DefaultDisplayMode("iPhone")
            {
                ContextCondition = (context => context.GetOverriddenUserAgent().IndexOf
                  ("iPhone", StringComparison.OrdinalIgnoreCase) >= 0)
            });
        }
    }
}