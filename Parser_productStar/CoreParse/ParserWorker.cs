﻿using AngleSharp.Html.Parser;
using System;

namespace Parser_productStar.CoreParse
{
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;

        HtmlLoader loader;
        bool isActive;

        public IParser<T> Parser 
        {
            get { return parser; } 
            set { parser = value; }
        }

        public IParserSettings Settings
        {
            get { return parserSettings; }
            set 
            {
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }

        public bool IsActive { get { return isActive; } }

        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;

        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Stop()
        { 
            isActive = false;
        }

        private async void Worker()
        {
            for (int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }

                var source = await loader.GetSourseByPageId(i);
                var domParser = new HtmlParser();

                var document = await domParser.ParseDocumentAsync(source);

                var result = parser.Parse(document);

                OnNewData?.Invoke(this, result);
             }

            OnCompleted?.Invoke(this);
            isActive = false;
        }
    }
}
