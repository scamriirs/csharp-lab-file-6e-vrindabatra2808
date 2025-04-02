namespace List_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Fruits.SelectedItem != null)
            {
                MessageBox.Show("You selected: " + Fruits.SelectedItem.ToString(), "Selected Item");
            }
            else
            {
                MessageBox.Show("Please select an item from the list.", "No Selection");
            }
        }
    }
}
