using System;
using System.Collections.Generic;
using System.Text;

namespace web1_1.DAL.Entities
{
    public class WheelchairGroup
    {
        public int WheelchairGroupId { get; set; }
        public string GroupName { get; set; }
        /// <summary>
        /// Навигационное свойство 1-ко-многим
        /// </summary>
        public List<Wheelchair> Wheelchairs { get; set; }
    }
}
