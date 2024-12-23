﻿using SIS.HTTP.Common;
using SIS.HTTP.Cookies;
using SIS.HTTP.Enums;
using SIS.HTTP.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.HTTP.Responses
{
    public class HttpResponse : IHttpResponse
    {
        public HttpResponse()
        {
            this.Headers = new HttpHeaderCollection();
            this.Content = new byte[0];
            this.CookieCollection = new HttpCookieCollection();
            this.Headers.AddHeader(new HttpHeader("Date", $"{DateTime.UtcNow:r}"));
        }

        public HttpResponse(string content, HttpResponseStatusCode statusCode) : this()
        {
            CoreValidator.ThrowIfNull(StatusCode, nameof(statusCode));
            this.StatusCode = statusCode;
            this.Content = Encoding.UTF8.GetBytes(content);
            this.Headers.AddHeader(new HttpHeader("Content-Length", $"{this.Content.Length}"));
        }

        public HttpResponse(byte[] content, HttpResponseStatusCode statusCode,string contentType) : this()
        {
            CoreValidator.ThrowIfNull(StatusCode, nameof(statusCode));
            this.StatusCode = statusCode;
            this.Content = content;
            this.Headers.AddHeader(new HttpHeader("Content-Length", $"{this.Content.Length}"));
            this.Headers.AddHeader(new HttpHeader("Content-Type", contentType));
        }

        public HttpResponseStatusCode StatusCode { get; set; }
        public IHttpHeaderCollection Headers { get; }
        public byte[] Content { get; set; }

        public IHttpCookieCollection CookieCollection {get;}

        public void AddCookie(HttpCookie cookie)
        {
            this.CookieCollection.AddCookie(cookie);
        }

        public void AddHeader(HttpHeader header)
        {
            CoreValidator.ThrowIfNull(header, nameof(header));
            this.Headers.AddHeader(header);
        }

        public byte[] GetBytes()
        {
            return Encoding.UTF8.GetBytes(this.ToString()).Concat(Content).ToArray();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"{GlobalConstants.HttpOneProtocolFragments} {(int)this.StatusCode} {this.StatusCode.ToString()}")
                .Append(GlobalConstants.HttpNewLine)
                .Append(this.Headers)
                .Append(GlobalConstants.HttpNewLine);

            if (this.CookieCollection.HasCookies())
            {
                result.Append($"Set-Cookie: {this.CookieCollection}").Append(GlobalConstants.HttpNewLine);
            }

            result.Append(GlobalConstants.HttpNewLine);

            return result.ToString();
        }
    }
}
