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

        static int size = 24;
        static int stroke = 1;
        static float opacity = 100;

        public static int Size_ {  get { return size; } set {  size = value; } }
        public static int Stroke {  get { return stroke; } set { stroke = value; } }
        public static float Opacity {  get { return opacity; } set { opacity = value/100; } }

        private static Bitmap SvgToBitmap(string svg)
        {
            svg = (string.IsNullOrWhiteSpace(svg)) ?svgNull:svg;
            SvgDocument icon = SvgDocument.FromSvg<SvgDocument>(svg);
            Bitmap bitmap;

            icon.StrokeWidth = stroke;
            icon.Opacity = opacity;
            bitmap = icon.Draw(size, size);
            
            return bitmap;
        }

        public static Bitmap Set(string iconname)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            string[] resourceNames = assembly.GetManifestResourceNames();
            Bitmap bitmap;
            bitmap = SvgToBitmap(OpenIcon.GetIcon(iconname).Svg);
            return bitmap;
        }
    }//<svg viewBox = "0 0 24 24" class="w-7 h-7" fill="none" stroke="black" stroke-width="1.7" stroke-linecap="round" stroke-linejoin="round"><path d = "M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z" ></ path >< polyline points="9 22 9 12 15 12 15 22"></polyline></svg>
}
