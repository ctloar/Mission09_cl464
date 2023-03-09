using Microsoft.AspNetCore.Mvc;
using Mission09_cl464.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// passes in the list of categories to be used in the view component

namespace Mission09_cl464.Components
{
    public class CategoriesViewComponent : ViewComponent
    {
        private IBookstoreRepository repo { get; set; }

        public CategoriesViewComponent (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            var categories = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(categories);
        }
    }
}
