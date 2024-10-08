﻿namespace Parser_productStar.CoreParse.Habra
{
    internal class HabraSettings : IParserSettings
    {
        public HabraSettings(int start, int end) 
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseUrl { get; set; } = "https://pikabu.ru/";
        public string Prefix { get; set; } = "";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
