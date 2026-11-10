
namespace OpenIconPack
{
    public partial class OpenIcon
    {
        public static string svgNull = "<svg viewBox=\"0 0 200 200\" width=\"200\" height=\"200\"> <circle cx=\"100\" cy=\"100\" r=\"90\" fill=\"#E53935\" /> <circle cx=\"100\" cy=\"100\" r=\"70\" fill=\"#FFFFFF\" /> <rect x=\"40\" y=\"82\" width=\"120\" height=\"36\" rx=\"8\" fill=\"#E53935\" /></svg>";

        static int defaultSize = 24;
        static float defaultStroke = 1;
        static float defaultOpacity = 100;

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

        public static string DefaultStrokeColorHex { get; set; } = "#000000";

        public static string GetSvg(string iconName=null)
        {
            if (iconName == null) { return svgNull; }
            return OpenIcon.GetIcon(iconName).Svg;
        }

    }
}
