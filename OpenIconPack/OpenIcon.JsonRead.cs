using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace OpenIconPack
{
    public partial class OpenIcon
    {
        private static IconPack _iconPack;

        public static IconPack GetIconPack()
        {
            if (_iconPack == null)
            {
                string jsonString = File.ReadAllText("json/OpenIconPack_Default.json"); 
                _iconPack = JsonSerializer.Deserialize<IconPack>(jsonString);
            }
            return _iconPack;
        }
        public static IconItem GetIcon(string iconName)
        {
            var pack = GetIconPack();
            foreach (var category in pack.Icons.Values)
            {
                var found = category.FirstOrDefault(x => x.Name == iconName);
                if (found != null) return found;
            }
            return null; 
        }
    }
    public class IconPack
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("icons")]
        public Dictionary<string, List<IconItem>> Icons { get; set; }
    }

    public class IconItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        [JsonPropertyName("svg")]
        public string Svg { get; set; }
    }
}
