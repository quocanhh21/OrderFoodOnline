using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OderFoodOnline
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.IgnoreRoute("{*botdetect}",
    new { botdetect = @"(.*)BotDetectCaptcha\.ashx" });

            routes.MapRoute(
             name: "Product Category",
             url: "products/{metatitle}-{id}",
             defaults: new { controller = "Product", action = "Category", id = UrlParameter.Optional },
             namespaces: new[] { "OderFoodOnline.Controllers" }
         );

            routes.MapRoute(
            name: "Product Detail",
            url: "product-single/{metatitle}-{id}",
            defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
            namespaces: new[] { "OderFoodOnline.Controllers" }
        );

            routes.MapRoute(
           name: "About",
           url: "about",
           defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional },
           namespaces: new[] { "OderFoodOnline.Controllers" }
       );

            routes.MapRoute(
          name: "News",
          url: "news",
          defaults: new { controller = "News", action = "Index", id = UrlParameter.Optional },
          namespaces: new[] { "OderFoodOnline.Controllers" }
      );
            routes.MapRoute(
          name: "Contact",
          url: "contact",
          defaults: new { controller = "Contact", action = "Index", id = UrlParameter.Optional },
          namespaces: new[] { "OderFoodOnline.Controllers" }
      );
            routes.MapRoute(
         name: "Cart",
         url: "cart",
         defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional },
         namespaces: new[] { "OderFoodOnline.Controllers" }
     );
            routes.MapRoute(
         name: "Register",
         url: "register",
         defaults: new { controller = "UserClient", action = "Register", id = UrlParameter.Optional },
         namespaces: new[] { "OderFoodOnline.Controllers" }
     );
            routes.MapRoute(
        name: "Login",
        url: "login",
        defaults: new { controller = "UserClient", action = "Login", id = UrlParameter.Optional },
        namespaces: new[] { "OderFoodOnline.Controllers" }
    );

            routes.MapRoute(
         name: "Payment",
         url: "payment",
         defaults: new { controller = "Cart", action = "Payment", id = UrlParameter.Optional },
         namespaces: new[] { "OderFoodOnline.Controllers" }
     );
            routes.MapRoute(
        name: "Add Cart",
        url: "add-cart",
        defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
        namespaces: new[] { "OderFoodOnline.Controllers" }
    );
            routes.MapRoute(
       name: "Payment success",
       url: "success",
       defaults: new { controller = "Cart", action = "Success", id = UrlParameter.Optional },
       namespaces: new[] { "OderFoodOnline.Controllers" }
   );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "HomeUser", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "OderFoodOnline.Controllers" }
            );


        }
    }
}
