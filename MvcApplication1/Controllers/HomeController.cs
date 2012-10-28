using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook;

namespace MvcApplication1.Controllers
{
  public class HomeController : Controller
  {
    const string APP_ID = "200675312221";
    const string SECRET_ID = "d561c22cc0b1a4bd0156c4333c7ecbe4";
    public ActionResult Index()
    {
      ViewBag.Message = "Modifiez ce modèle pour dynamiser votre application ASP.NET MVC.";
      FacebookClient client = new Facebook.FacebookClient();
      var obj= client.Get("oauth/access_token",
        new
        {
          client_id = APP_ID,
          redirect_uri = "http://localhost:2548/",
          client_secret = SECRET_ID,
          code = "AQCz5EJ85SAyjvPxilbh8I9Xf32bBR4W31SUhtmgIkko_ImsI06fw1jzrPvHHA2wawIjWNzXhaDy8wKfm2jclNI2pUrGxQEN2IC-EZNAQBd0RV50kp-xDBZTYVC43dVN8D3z-2M7NuYANIQGkRw-IlWQZnL0OSW_qrNPiR3hvgNbBwvJznSECVQh2Xt_OrMcgwHl8EGa1d2dP4kIEmBggbxU#_=_"
        });
      
      return View();
    }
    //https://graph.facebook.com/oauth/authorize?client_id=200675312221&redirect_uri=http://localhost:2548/&scope=read_insights,offline_access

    public ActionResult About()
    {
      ViewBag.Message = "Votre page de description d’application.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Votre page de contact.";

      return View();
    }

    private Uri GenerateLoginUrl(string appId, string extendedPermissions)
    {
      // for .net 3.5
      // var parameters = new Dictionary<string,object>
      // parameters["client_id"] = appId;
      dynamic parameters = new ExpandoObject();
      parameters.client_id = appId;
      parameters.redirect_uri = "https://www.facebook.com/connect/login_success.html";

      // The requested response: an access token (token), an authorization code (code), or both (code token).
      parameters.response_type = "token";

      // list of additional display modes can be found at http://developers.facebook.com/docs/reference/dialogs/#display
      parameters.display = "popup";

      // add the 'scope' parameter only if we have extendedPermissions.
      if (!string.IsNullOrWhiteSpace(extendedPermissions))
        parameters.scope = extendedPermissions;

      // generate the login url
      var fb = new FacebookClient();
      return fb.GetLoginUrl(parameters);
    }
  }

}
