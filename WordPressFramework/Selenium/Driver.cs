﻿using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WordPressFramework.Selenium
{
    public static class Driver
    {
        public static IWebDriver Instance { get; private set; }

        public static string Title => Instance.Title;

        public static string BaseAddress => "http://localhost/site/";

        public static void Initialize()
        {
            Instance = new ChromeDriver("C:\\DEV\\SeleniumTests");
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void Close()
        {
            Instance.Close();
        }

        public static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int) (timeSpan.TotalSeconds * 1000));
        }
    }
}