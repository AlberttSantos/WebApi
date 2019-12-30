using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ApiEstudo.Web.Controllers
{
    public class BaseController : ControllerBase
    {
        protected ObjectResult Error(object value)
        {
            return new ObjectResult(value)
            {
                StatusCode = (int)HttpStatusCode.InternalServerError
            };
        }
    }
}