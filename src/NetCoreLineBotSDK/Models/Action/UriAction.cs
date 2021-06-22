﻿using NetCoreLineBotSDK.Enums;
using NetCoreLineBotSDK.Interfaces;

namespace NetCoreLineBotSDK.Models.Action
{
    public class UriAction : IAction, IRequestMessage
    {
        /// <param name="uri">網址</param>
        /// <param name="label">顯示文字</param>
        public UriAction(string uri, string label)
        {
            Uri = uri;
            Label = label;
        }
        public string Uri { get; set; }
        public ActionType Type => ActionType.Uri;
        public string Label { get; set; }
    }

}
