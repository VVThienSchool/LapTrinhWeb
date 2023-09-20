using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MyWebApp.Models;

namespace MyWebApp.ViewComponents
{
    public class RenderViewComponent:ViewComponent
    {
        private List<MenuItem> MenuItems;

        public RenderViewComponent()
        {
            MenuItems = new List<MenuItem>()
            {
                new MenuItem(1, "Branches", "Branches/List"),
                new MenuItem(2, "Students", "Students/List"),
                new MenuItem(3, "Subjects", "Subjects/List"),
                new MenuItem(4, "Courses", "Courses/List")
            };
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderLeftMenu", MenuItems);
        }
    }
}
