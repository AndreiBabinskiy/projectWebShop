using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using web1_1.DAL.Data;
using web1_1.DAL.Entities;
using web1_1.Extensions;
using web1_1.Models;

namespace web1_1.Controllers
{
    public class ProductController : Controller
    {
        //public List<Wheelchair> _wheelchairs;
        //public List<WheelchairGroup> _wheelchairGroups;

        public ApplicationDbContext _context;
        int _pageSize;
        private ILogger _logger;

        public ProductController(ApplicationDbContext context, ILogger<ProductController> logger)
        {
            _pageSize = 4;
            _context = context;
            _logger = logger;
            //SetupData();
        }
        [Route("Catalog")]
        [Route("Catalog/Page_{pageNo}")]
        public IActionResult Index(int? group, string? SearchQuery, int pageNo = 1)
        {
            ViewData["Groups"] = _context.WheelchairGroups;
            ViewData["CurrentGroup"] = group ?? 0;

            var productList = new List<Wheelchair>();
            if (SearchQuery != null)
            {
                productList = _context.Wheelchairs.Where(d => d.WheelchairName.ToLower().Contains(SearchQuery.ToLower())).ToList();
            }
            else
            {
                productList = _context.Wheelchairs.Where(d => !group.HasValue || d.WheelchairGroupId == group.Value).ToList();
            }

            var model = ListViewModel<Wheelchair>.GetModel(productList, pageNo, _pageSize);
            if (Request.IsAjaxRequest())
                return PartialView("_listpartial", model);
            else
                return View(model);
        }

        [HttpPost]
        public string Index1(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;

        }
        /// <summary>
        /// Инициализация списков
        /// </summary>
        //private void SetupData()
        //{
        //    _wheelchairGroups = new List<WheelchairGroup>
        //    {
        //        new WheelchairGroup {WheelchairGroupId=1, GroupName="Активные инвалидные коляски"},
        //        new WheelchairGroup {WheelchairGroupId=2, GroupName="Инвалидные коляски с электроприводом"},
        //        new WheelchairGroup {WheelchairGroupId=3, GroupName="Кресло-коляски для инвалидов с ДЦП"},
        //        new WheelchairGroup {WheelchairGroupId=4, GroupName="Кресло-коляски для инвалидов с ручным приводом"},
        //        new WheelchairGroup {WheelchairGroupId=5, GroupName="Складные инвалидные кресла рычажного типа"}                
        //    };

        //    _wheelchairs = new List<Wheelchair>
        //    {
        //        new Wheelchair {WheelchairId = 1, WheelchairName="Кушаль",
        //        Description="Вес 10 кг, Спинка 35 см, Сиденье 30 см, Обода - резина, Корпус - Карбон",
        //        Price = 2400, WheelchairGroupId = 1, Image="kus1.jpg" },
        //        new Wheelchair { WheelchairId = 2, WheelchairName="Ортоника",
        //        Description="Вес 15 кг, Спинка 40 см, Сиденье 40 см, Обода - резина, Корпус - Алюминий",
        //        Price =650, WheelchairGroupId=1, Image="orton1.jpg" },
        //        new Wheelchair { WheelchairId = 3, WheelchairName="Электро проходимец",
        //        Description="Вес 130 кг, Спинка 90 см, Сиденье 50 см, Скорость 15 км/ч, Запас хода 50 км ",
        //        Price =5000, WheelchairGroupId=2, Image="elec1.jpg" },
        //        new Wheelchair { WheelchairId = 4, WheelchairName="Коляска для ДЦП-1",
        //        Description="Вес 15 кг, Спинка 90 см, Сиденье 50 см, Столик",
        //        Price =500, WheelchairGroupId=3, Image="dzp1.jpg" },
        //        new Wheelchair { WheelchairId = 5, WheelchairName="Ручная 1",
        //        Description="Вес 20 кг, Спинка 40 см, Сиденье 45 см",
        //        Price=150, WheelchairGroupId=4, Image="rush1.jpg" },
        //        new Wheelchair { WheelchairId = 6, WheelchairName="Складная 1",
        //        Description="Вес 18 кг, Спинка 45 см, Сиденье 40 см",
        //        Price =280, WheelchairGroupId=5, Image="sck1.jpg" }
        //    };
        //}
    }
}
