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
        static float defaultStroke = 1;
        static float defaultOpacity = 100;
        static Color defaultStrokeColor = Color.Black;

        public static int DefaultSize 
        {
            get { return defaultSize; }
            set { defaultSize = value; }
        }
        public static float  DefaultStroke 
        { 
            get { return defaultStroke; }
            set { defaultStroke = value; }
        }
        public static float DefaultOpacity 
        { 
            get { return defaultOpacity; }
            set { defaultOpacity = value/100;}
        }

        public static Color DefaultStrokeColor 
        {
            get { return defaultStrokeColor;}
            set { defaultStrokeColor = value; }
        }

        private static Bitmap SvgToBitmap(string svg,int? size=null,float? stroke=null,Color? stroke_color=null,float? opacity=null)
        {
            svg = (string.IsNullOrWhiteSpace(svg)) ?svgNull:svg;
            SvgDocument icon = SvgDocument.FromSvg<SvgDocument>(svg);
            Bitmap bitmap;

            icon.StrokeWidth = (stroke.HasValue)?(int)stroke: defaultStroke;
            icon.Opacity = (opacity.HasValue)?(float)opacity: defaultOpacity;
            icon.Stroke =new SvgColourServer((stroke_color.HasValue)?(Color)stroke_color:defaultStrokeColor);
            int _size = (size.HasValue) ?(int)size:defaultSize;
            bitmap = icon.Draw(_size, _size);
            
            return bitmap;
        }

        public static Bitmap Set(string iconname, int? size = null, float? stroke = null,Color? stroke_color=null, float? opacity = null)
        {
            Bitmap bitmap;
            bitmap = SvgToBitmap(OpenIcon.GetIcon(iconname).Svg,size,stroke,stroke_color,opacity);
            return bitmap;
        }
    }
}
