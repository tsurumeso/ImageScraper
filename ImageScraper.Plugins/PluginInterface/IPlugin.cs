﻿using System.Net;
using System.Collections.Generic;

namespace ImageScraper.Plugins
{
    public interface IPlugin
    {
        string Name { get; }
        bool Enabled { get; }
        bool IsExclusive { get; }
        bool IsLoggedIn { get; }
        Utilities.Logger Logger { set; }

        void PreProcess();
        void PostProcess();
        void LoadSettings();
        void SaveSettings();
        void ShowPluginForm();
        bool Login(bool force = false);
        CookieCollection GetCookieCollection();
        bool IsIgnore(string url);
        bool IsParse(string url);
        List<UrlContainer.UrlContainer> GetLinkList(HtmlContainer.HtmlContainer hc);
        List<UrlContainer.UrlContainer> GetImageUrlList(UrlContainer.UrlContainer uc, string[] format);
    }
}
