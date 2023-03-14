using System;
using System.Collections.Generic;
using System.Text;

namespace web1_1.DAL.Entities
{
    public class Wheelchair
    {
        public int WheelchairId { get; set; } // id инва коляскои
        public string WheelchairName { get; set; } // название колясски
        public string Description { get; set; } // описание коляски
        public int Price { get; set; } // цена коляски
        public string Image { get; set; } // имя файла изображения
                                          // Навигационные свойства
        /// <summary>
        /// группа колясок (например, активки, ручные, электро,дцп и т.д.)
        /// </summary>
        public int WheelchairGroupId { get; set; }
        public WheelchairGroup Group { get; set; }
    }
}
