﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SkyMallCore.WebApiUtils;

namespace SkyMallCore.WebApi.Controllers
{
    /// <summary>
    /// 基类
    /// </summary>
    [Route("api/[controller]")]
    public class ApiControllerBase : Controller
    {
        /// <summary>
        /// 请求辅助类
        /// </summary>
        public HttpClientHelper HttpClientHelper;





        public override void OnActionExecuting(ActionExecutingContext context)
        {
            HttpClientHelper = new HttpClientHelper((IHttpClientFactory)HttpContext.RequestServices.GetService(typeof(IHttpClientFactory)), "http://localhost:63656/");
            base.OnActionExecuting(context);
        }





        /// <summary>
        /// 成功
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public ApiResult<T> Success<T>(T data,string message=null)
        {
            return new ApiResult<T>(data,message:message);
        }


        /// <summary>
        /// 失败
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <returns></returns>
        public ApiResult<T> Failed<T>(string message)
        {
            return new ApiResult<T>(default(T), false, message: message);
        }


    }
}