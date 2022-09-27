namespace WinForms_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void run_label_MouseHover(object sender, EventArgs e)
        {
            Point newPos = new Point();
            newPos.X = Random.Shared.Next(1, Size.Width - run_label.ClientSize.Width);
            newPos.Y = Random.Shared.Next(1, Size.Height - run_label.ClientSize.Height - 50);
            newPos.Y = Random.Shared.Next(1, Size.Height - run_label.ClientSize.Height * 2 - 10);

            run_label.Location = newPos;
        }
    }
}