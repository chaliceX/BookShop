using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteGate.ashx
{
    /// <summary>
    /// HandleUser 的摘要说明
    /// </summary>
    public class HandleUser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var request = context.Request;
            string username = request["username"];
            string email = request["email"];
            string city = request["city"];
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}