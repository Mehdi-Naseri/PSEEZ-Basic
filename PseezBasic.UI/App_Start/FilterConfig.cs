﻿using System.Web;
using System.Web.Mvc;

namespace PseezBasic.UI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //با اضافه کردن این بخش جهت دسترسی به کلیه صفحات باید لوگ این کرد
            filters.Add(new AuthorizeAttribute());
        }
    }
}
