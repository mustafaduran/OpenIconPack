using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OpenIconPack
{
    public partial class OpenIcon
    {
        private static IconPack _iconPack;

        private static string LoadJson()
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            string[] resourceNames = assembly.GetManifestResourceNames();
            

            using (Stream stream = assembly.GetManifestResourceStream(resourceNames[0]))
            {
                if (stream == null)
                {
                    throw new FileNotFoundException("Gömülü JSON dosyası bulunamadı. Lütfen kaynak adını kontrol edin.");
                }

                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        private static IconPack GetIconPack()
        {
            if (_iconPack == null)
            {
                _iconPack = JsonSerializer.Deserialize<IconPack>(LoadJson());
            }
            return _iconPack;
        }
        private static IconItem GetIcon(string iconName)
        {
            IconItem icon=GetIconPack().Icons.FirstOrDefault(x=>x.Name==iconName);            
            return (icon==null)?new IconItem():icon; 
        }
    }
    public class IconPack
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("icons")]
        public List<IconItem> Icons { get; set; }
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
