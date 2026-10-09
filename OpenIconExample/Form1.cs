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

            button1.Image=OpenIcon.Set(IconName.cut);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IconAayar();
            //button1.ImageAlign = ContentAlignment.MiddleLeft;
            //int size = (int)sizeInput.Value;
            //button1.Image = OpenIcon.SvgToBitmap(richTextBox1.Text.ToString());
            button1.Image = OpenIcon.Set(IconName.mail);
        }

        public void IconAayar()
        {
            OpenIcon.Size_=(int)sizeInput.Value;
            OpenIcon.Opacity=(float)opacityInput.Value;
            OpenIcon.Stroke = (int)strokeInput.Value;
        }
    }
}
