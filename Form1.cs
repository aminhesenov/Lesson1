namespace Lesson1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Düyməyə klikləndi");

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //label1.Text = "Əli Xəlilov";
            label4.Text = "Əli";
            label5.Text = "Xəlilov";
            label6.Text = "Tələbə";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = (textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("Mexanika mühəndisliyi");
            comboBox1.Items.Add(textBox2.Text);
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.Text);
        }
    }
}