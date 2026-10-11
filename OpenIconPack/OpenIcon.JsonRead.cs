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
        static string? jsonUrl = null;
        static string? jsonPath = null;
        public static string JsonUrl
        {
            get { return jsonUrl; }
            set { jsonUrl = value; }
        }

        public static string JsonPath
        {
            get { return jsonPath; }
            set { jsonPath = value; }
        }

        private static string LoadJson()
        {
            if(jsonPath!=null)
            {
                return File.ReadAllText(jsonPath);
                
            }
            else if(jsonUrl!=null)
            {
                return "jsonurl";
            }
            else 
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
        }

        private static IconPack GetIconPack()
        {
            if (_iconPack == null)
            {
                try
                {
                    _iconPack = JsonSerializer.Deserialize<IconPack>(LoadJson());
                }
                catch (Exception)
                {
                    _iconPack= new IconPack();
                }
            }
            return _iconPack;
        }
        private static IconItem GetIcon(string iconName)
        {
            var pack = GetIconPack();
            if (pack?.Icons == null) return null;
            return pack.Icons.FirstOrDefault(x => x.Name == iconName);
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
