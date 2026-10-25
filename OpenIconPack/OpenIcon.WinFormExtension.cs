using System.Drawing;
using System.IO;
using Svg;
namespace OpenIconPack
{
    public static partial class WinFormExtension
    {
        public static Color DefaultStrokeColor { get; set; } = Color.Black;
         
        private static Bitmap SvgToBmp(string? svg=null, int? size=null, float? stroke=null, Color? stroke_color=null, float? opacity = null)
        {
            string svg_ = svg ?? OpenIcon.svgNull;
            int size_=size??OpenIcon.DefaultSize;
            float stroke_=stroke??OpenIcon.DefaultStroke;
            float opacity_ = opacity ?? OpenIcon.DefaultOpacity;
            Color stroke_color_ = stroke_color ?? DefaultStrokeColor;


            SvgDocument icon = SvgDocument.FromSvg<SvgDocument>(svg_);
            Bitmap bitmap;

            icon.StrokeWidth = stroke_;
            icon.Opacity = opacity_;
            icon.Stroke = new SvgColourServer(stroke_color_);
            int _size = size_;
            bitmap = icon.Draw(_size, _size);

            return bitmap;
        }

        public static Bitmap GetBitmap(string iconName, int? size = null, Color? color = null)
        {
            string svg = OpenIcon.GetSvg(iconName);
            return SvgToBmp(svg, size, stroke_color: color);
        }
    }
}
