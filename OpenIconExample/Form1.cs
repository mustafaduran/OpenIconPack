using OpenIconPack;
namespace OpenIconExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IconAayar();
            button1.ImageAlign = ContentAlignment.MiddleLeft;

            button1.Image = OpenIcon.Set(IconName.cut);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            IconAayar();
            //button1.ImageAlign = ContentAlignment.MiddleLeft;
            //int size = (int)sizeInput.Value;
            //button1.Image = OpenIcon.SvgToBitmap(richTextBox1.Text.ToString());
            button1.Image = OpenIcon.Set("main_menu");

        }

        public void IconAayar()
        {
            
            OpenIcon.DefaultSize = (int)sizeInput.Value;
            OpenIcon.DefaultOpacity = (float)opacityInput.Value;
            OpenIcon.DefaultStroke = (int)strokeInput.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
