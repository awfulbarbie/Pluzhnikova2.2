namespace lab2._4_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            int a = 9;
            double x = 1;
            int flag = 0;

            while (a - 5 > 0)
            {
                if (flag == 0)
                {
                    textBox1.Text = (a.ToString());
                    flag = 1;
                }
                else
                {

                    for (double i = 1.1; i <= x; i++)
                        textBox1.Text += (a.ToString() + " ");
                    textBox1.Text += Environment.NewLine;
                    for (int j = 1; j <= x; j++)
                        textBox1.Text += ((a - 5).ToString() + " ");
                    textBox1.Text += Environment.NewLine;

                    x += 1.5;
                    a--;
                }
            }
        }
    }
}