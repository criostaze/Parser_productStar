﻿using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Parser_productStar.CoreParse.Habra
{
    class HabraParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("story__title-link"));

            foreach(var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();

        }
    }
}
