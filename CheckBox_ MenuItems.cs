using System.Numerics;

namespace menu
{
    public partial class Form1 : Form
    {
        public string select = "You have ordered: ";
        public int total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                select = select + "\n Burger";
                total = total + 100;
            }
            if (checkBox2.Checked == true)
            {
                select = select + "\n Pizza";
                total = total + 90;
            }
            if (checkBox3.Checked == true)
            {
                select = select + "\n Coffee";
                total = total +50;
            }
            if (checkBox4.Checked == true)
            {
                select = select + "\n Coke";
                total = total + 30;
            }
            if (select == "You have selected")
            {
                MessageBox.Show("You have selected nothing");
            }
            else
            {
                MessageBox.Show(select + "\n Your bill is: " + total);
            }
        }
    }
}
