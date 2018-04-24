using System;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace Todo.Business.Facada.WebService
{
    internal class CustomControllerSelector : DefaultHttpControllerSelector
    {
        private HttpConfiguration config;

        public CustomControllerSelector(HttpConfiguration config) : base(config)
        {
            this.config = config;
        }

        public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            try
            {
                var controllers = GetControllerMapping();
                var routeData = request.GetRouteData();

                var controllerName = routeData.Values["controller"].ToString();

                HttpControllerDescriptor controllerDescriptor;

                if (GetVersionFromAcceptHeader(request) == "v1")
                {
                    if (controllers.TryGetValue(controllerName, out controllerDescriptor))
                    {
                        return controllerDescriptor;
                    }

                }
                else
                {
                    controllerName = string.Concat(controllerName, "v2");
                    if (controllers.TryGetValue(controllerName, out controllerDescriptor))
                    {
                        return controllerDescriptor;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private string GetVersionFromQueryString(HttpRequestMessage request)
        {
            var version = HttpUtility.ParseQueryString(request.RequestUri.Query);
            return version[0] != null ? version[0] : "v1";

        }

        private string GetVersionFromHeader(HttpRequestMessage request)
        {
            const string HEADER_NAME = "Version-Num";

            if (request.Headers.Contains(HEADER_NAME))
            {
                var versionHeader = request.Headers.GetValues(HEADER_NAME).FirstOrDefault();
                if (versionHeader != null)
                {
                    return versionHeader;
                }
            }

            return "v1";
        }

        private string GetVersionFromAcceptHeader(HttpRequestMessage request)
        {
            var acceptHeader = request.Headers.Accept;

            foreach (var mime in acceptHeader)
            {
                if (mime.MediaType == "application/json")
                {
                    return "v2";
                }
                else if (mime.MediaType == "application/xml")
                {
                    return "v1";
                }
                else { return "v1"; }

            }
            return "v1";
        }
    }
}