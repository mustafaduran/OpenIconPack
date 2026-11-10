using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenIconPack
{
    public static partial class AspNetExtension
    {
        public static string GetSvg(string iconName, string colorHex = null, int size = 0)
        {
            string svg = OpenIcon.GetSvg(iconName);

            if (string.IsNullOrEmpty(svg))
                return OpenIcon.svgNull;

            return svg;
        }

        
        public static string ToSvg(this string iconName, string colorHex = null, int size = 0)
        {
            return GetSvg(iconName, colorHex, size);
        }
    }
}
