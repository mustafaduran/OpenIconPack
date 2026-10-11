using OpenIconPack;

namespace OpenIconExample
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           // OpenIcon.JsonPath = "C:\\Users\\User\\Documents\\MyIconPack.json";
            OpenIcon.JsonUrl = "https://raw.githubusercontent.com/mustafaduran/OpenIconPack_JSON/refs/heads/main/OpenIconPack_Default.json";
            OpenIcon.DefaultStroke = 1.8f;
            OpenIcon.DefaultStrokeColor = Color.Gray;
            OpenIcon.DefaultSize = 32;
            Application.Run(new Form1());
           
        }
    }
}