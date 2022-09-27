namespace WinForms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        short labelNumber = 1;
        Point startPoint = new Point(0, 0);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Size size = new(e.X - startPoint.X, e.Y - startPoint.Y);

            if (size.Width < 0)
            {
                size.Width = -size.Width;
                startPoint.X -= size.Width;
            }
            if (size.Height < 0)
            {
                size.Height = -size.Height;
                startPoint.Y -= size.Height;
            }

            if (size.Width <= 10 || size.Height <= 10)
            {
                MessageBox.Show("You can't create a label smaller than 10x10...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Label label = new Label
            {
                Text = $"Label {labelNumber}",
                Size = size,
                Location = startPoint,
                BackColor = Color.Gray
            };
            label.Click += Label_Click;
            label.DoubleClick += Label_DoubleClick;
            label.SendToBack();

            Controls.Add(label);
            labelNumber++;
        }

        private void Label_DoubleClick(object? sender, EventArgs e)
        {
            (sender as Label).Dispose();
        }

        private void Label_Click(object? sender, EventArgs e)
        {
            Label l = sender as Label;
            Text = $"Location : {l.Location.ToString()} , Field : {l.Size.Width * l.Size.Height}";
        }
    }
}