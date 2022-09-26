using System;
using System.Collections.Generic;

namespace GreenShop.Shared
{
    public class ServiceResponse<T>
    {
        // T Data - will be the list of Products that are passed into different Service Responses
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }
}

