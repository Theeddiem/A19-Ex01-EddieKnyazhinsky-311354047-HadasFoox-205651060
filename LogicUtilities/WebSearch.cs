﻿using System;
using System.Text;

namespace LogicUtilities
{
    public class WebSearch
    {
        public Func<string> CurrentSearchEngine = () => @"http://www.google.com/search?q=";

        public string GetPlaceWebSearch(string i_SelectedPlaceStr)
        {
            StringBuilder WebAddress = new StringBuilder();
            WebAddress.Append(CurrentSearchEngine.Invoke());
            WebAddress.Append(i_SelectedPlaceStr);

            return WebAddress.ToString();
        }
    }
}
