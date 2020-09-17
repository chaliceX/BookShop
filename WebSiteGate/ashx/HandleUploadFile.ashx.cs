using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace WebSiteGate.ashx
{
    /// <summary>
    /// HandleUploadFile 的摘要说明
    /// </summary>
    public class HandleUploadFile : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //处理上传文件
            context.Response.ContentType = "text/plain";

            var file = context.Request.Files["picture"];

            //设置随机名称和路径
            string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

            file.SaveAs(context.Request.MapPath("/resource/upload"+"/"+filename));
            var backJsonObject = new
            {
                 code = 0
                , msg = ""
                , data = new {
                src = "http://cdn.layui.com/123.jpg"}

            };
            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(backJsonObject);
            
            context.Response.Write(jsonData);
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