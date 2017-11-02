
using System.Web.Mvc;

namespace BowenSerene
{
    using Serenity.Services;
    using System;
    using System.Collections.Generic;

    public class ExcelDownRequest : ServiceRequest
    {
        public string ProductsList { get; set; }
    }

    public class ExcelDownResponse : ServiceResponse
    {
        public string ContentResult { get; set; }
    }
}