using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web1_1.Controllers
{
    public class ContactsController : Controller
    {
        public class ListDemo
        {
            public int ListItemValue { get; set; }
            public string ListItemText { get; set; }
        }

        public List<ListDemo> _listDemo;

        public ContactsController()
        {
            _listDemo = new List<ListDemo> {
                new ListDemo{ListItemValue=1,ListItemText="Директор - 8 (029) 350-28-19"},
                new ListDemo{ListItemValue=2,ListItemText="Консультант - 8 (029) 356-29-44"},
                new ListDemo{ListItemValue=3,ListItemText="Самовывоз - 8 (044) 758-39-48"}
            };
        }

        public IActionResult Index()
        {
            ViewData["Text"] = "Контакты";
            ViewData["List1"] = new SelectList(_listDemo, "ListItemValue", "ListItemText");
            return View();
        }
    }
}
