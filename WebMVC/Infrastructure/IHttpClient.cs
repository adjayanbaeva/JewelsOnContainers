﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebMVC.Infrastructure
{
    public interface IHttpClient
    {
        Task<string> GetStringAsync(string uri, 
            string authorizationToken = null, 
            string authorizationMethod = "Bearer");
        Task<HttpResponseMessage> PostAsync<T>(string uri, 
            T item, 
            string authorizarionToken = null, 
            string authorizationMethod = "Bearer");
    }
}
