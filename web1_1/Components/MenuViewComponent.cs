using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using web1_1.Models;

namespace web1_1.Components
{
    public class MenuViewComponent : ViewComponent
    {
        // Инициализация списка элементов меню
        private List<MenuItem> _menuItems = new List<MenuItem>
        {
            new MenuItem{ Controller="Home", Action="Index", Text="Главная"},
            new MenuItem{ Controller="Product", Action="Index", Text="Каталог"},
            new MenuItem{ IsPage=true, Area="Admin", Page="/Index", Text="Администрирование", AdminOnly = true },
            new MenuItem {Controller="Order", Action="Index", Text="Как оформить заказ?"},
            new MenuItem{ Controller="Contacts", Action="Index", Text="Контакты"},
            new MenuItem { Controller="Delivery", Action="Index", Text="Доставка"},
            new MenuItem {Controller="Payment", Action="Index", Text="Оплата"}
        };

        public IViewComponentResult Invoke()
        {
            //Получение значений сегментов маршрута
            var controller = ViewContext.RouteData.Values["controller"];
            var page = ViewContext.RouteData.Values["page"];
            var area = ViewContext.RouteData.Values["area"];
            foreach (var item in _menuItems)
            {

                // Название контроллера совпадает?
                var _matchController = controller?.Equals(item.Controller)
                ?? false;
                // Название зоны совпадает?
                var _matchArea = area?.Equals(item.Area) ?? false;
                // Если есть совпадение, то сделать элемент меню активным
                // (применить соответствующий класс CSS)
                if (item.AdminOnly)
                {
                    if (!User.IsInRole("admin"))
                    {
                        item.Display = "none";
                        continue;
                    }
                }
                if (_matchController || _matchArea)
                {


                    item.Active = "active";
                }
            }
            return View(_menuItems);
        }
    }

}
