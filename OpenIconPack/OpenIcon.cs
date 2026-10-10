using Svg;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace OpenIconPack
{
    public partial class OpenIcon
    {
        private static string svgNull = "<svg viewBox=\"0 0 200 200\" width=\"200\" height=\"200\"> <circle cx=\"100\" cy=\"100\" r=\"90\" fill=\"#E53935\" /> <circle cx=\"100\" cy=\"100\" r=\"70\" fill=\"#FFFFFF\" /> <rect x=\"40\" y=\"82\" width=\"120\" height=\"36\" rx=\"8\" fill=\"#E53935\" /></svg>";

        static int defaultSize = 24;
        static int defaultStroke = 1;
        static float defaultOpacity = 100;

        public static int DefaultSize {  get { return defaultSize; } set {  defaultSize = value; } }
        public static int DefaultStroke {  get { return defaultStroke; } set { defaultStroke = value; } }
        public static float DefaultOpacity {  get { return defaultOpacity; } set { defaultOpacity = value/100; } }

        private static Bitmap SvgToBitmap(string svg,int? size=null,int? stroke=null,float? opacity=null)
        {
            svg = (string.IsNullOrWhiteSpace(svg)) ?svgNull:svg;
            SvgDocument icon = SvgDocument.FromSvg<SvgDocument>(svg);
            Bitmap bitmap;

            icon.StrokeWidth = (stroke.HasValue)?(int)stroke: defaultStroke;
            icon.Opacity = (opacity.HasValue)?(float)opacity: defaultOpacity;
            int _size = (size.HasValue) ?(int)size:defaultSize;
            bitmap = icon.Draw(_size, _size);
            
            return bitmap;
        }

        public static Bitmap Set(string iconname, int? size = null, int? stroke = null, float? opacity = null)
        {
            Bitmap bitmap;
            bitmap = SvgToBitmap(OpenIcon.GetIcon(iconname).Svg,size,stroke,opacity);
            return bitmap;
        }
    }//<svg viewBox = "0 0 24 24" class="w-7 h-7" fill="none" stroke="black" stroke-width="1.7" stroke-linecap="round" stroke-linejoin="round"><path d = "M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z" ></ path >< polyline points="9 22 9 12 15 12 15 22"></polyline></svg>
}
