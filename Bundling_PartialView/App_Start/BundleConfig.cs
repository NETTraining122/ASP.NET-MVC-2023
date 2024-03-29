﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Bundling1.App_Start
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
       {    
           StyleBundle(bundles);    
           ScriptBundle(bundles);    
       }    
    
       public static void StyleBundle(BundleCollection bundles)    
       {    
           bundles.Add(new StyleBundle("~/css")    
                    .Include("~/Content/bootstrap.css"));    
       }    
    
       public static void ScriptBundle(BundleCollection bundles)    
       {    
           bundles.Add(new ScriptBundle("~/js")    
                    .Include("~/Scripts/jquery-{version}.js")    
                    .Include("~/Scripts/bootstrap.js"));    
       }    
   }    
}
