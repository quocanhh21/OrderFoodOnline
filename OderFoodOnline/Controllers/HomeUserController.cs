using Model.DAO;
using OderFoodOnline.Common;
using OderFoodOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OderFoodOnline.Controllers
{
    public class HomeUserController : Controller
    {
        
        // GET: HomeUser
        public ActionResult Index()
        {
            ViewBag.Slides = new SlideDAO().ListAll();
            var productDAO = new ProductDAO();
            ViewBag.ListNewFoods = productDAO.ListNewFoods(6);
            ViewBag.ListFeatureFoods = productDAO.ListFeatueFoods(8);
            return View();
        }
        [ChildActionOnly]
        [OutputCache(Duration = 3600 * 24)]
        public ActionResult MainMenu()
        {
            var model = new MenuDAO().ListByGroupId(1);
            return PartialView(model);
        }
        [ChildActionOnly]
        
        public ActionResult MenuChild()
        {
            var model = new MenuDAO().ListByGroupId(2);
            return PartialView(model);
        }
        [ChildActionOnly]
        public PartialViewResult HeaderCart()
        {
            var cart = Session[CommonConstants.CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            
            return PartialView(list);
        }
        [ChildActionOnly]
        [OutputCache(Duration = 3600 * 24)]
        public ActionResult Footer()
        {
            var model = new FooterDAO().GetFooter();
            return PartialView(model);
        }
    }
}