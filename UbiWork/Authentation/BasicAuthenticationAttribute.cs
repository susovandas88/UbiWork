using System;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace UbiWork.Authentation
{
    public class BasicAuthenticationAttribute: AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            base.OnAuthorization(actionContext);
        }
    }
}
