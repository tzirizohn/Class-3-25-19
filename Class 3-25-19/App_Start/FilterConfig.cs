﻿using System.Web;
using System.Web.Mvc;

namespace Class_3_25_19
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
