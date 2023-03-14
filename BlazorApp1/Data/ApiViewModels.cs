using System.Text.Json.Serialization;

namespace BlazorApp1.Data
{
    public class ListViewModel
    {
        [JsonPropertyName("wheelchairId")]
        public int WheelchairId { get; set; } // id коляска
        [JsonPropertyName("wheelchairName")]
        public string WheelchairName { get; set; } // название коляски
    }
    public class DetailsViewModel
    {
        [JsonPropertyName("wheelchairName")]
        public string WheelchairName { get; set; } // название коляски
        [JsonPropertyName("description")]
        public string Description { get; set; } // описание коляски
        [JsonPropertyName("price")]
        public int Price { get; set; } // цена
        [JsonPropertyName("image")]
        public string Image { get; set; } // имя файла изображения
    }
}
