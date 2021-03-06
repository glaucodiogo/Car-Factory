﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CarFactory.Utils
{
    public class AppConfiguration
    {
        public static int AccessTokenExpireTimeInMin = GetInt("AccessTokenExpireTimeInMin", 5);

        public static int RefreshTokenExpireTimeInMin = GetInt("RefreshTokenExpireTimeInMin", 15);

        protected static string GetString(string key, string defaultValue)
        {
            var value = ConfigurationManager.AppSettings[key];
            return value ?? defaultValue;
        }

        protected static int GetInt(string key, int defaultValue)
        {
            return int.Parse(GetString(key, defaultValue.ToString()));
        }
    }

}