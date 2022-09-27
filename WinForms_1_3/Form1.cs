using WinForms_1_3.Properties;

namespace WinForms_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new();
            timer.Interval = 1000;

            timer.Tick += Timer_Tick;

            timer.Start();
        }

        bool isItBaku = true;
        private void Timer_Tick(object? sender, EventArgs e)
        {
            time_label.Text = isItBaku ? DateTime.Now.ToLongTimeString() : DateTime.UtcNow.ToLongTimeString();
        }

        private void baku_btn_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.baku;
            isItBaku = true;
        }

        private void london_btn_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.london;
            isItBaku = false;
        }
    }
}