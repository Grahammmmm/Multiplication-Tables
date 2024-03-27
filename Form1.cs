namespace Multiplication_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input;
            int integer;
            bool isNumeric;
            const int maxValue = 10;
            int startingFactor = 0;
            int factor;
            int product;
            input = Convert.ToString(textBox1.Text);
           isNumeric = int.TryParse(input, out integer);
            if (isNumeric)
            {
                for (startingFactor = 0; startingFactor <= maxValue; ++startingFactor)
                {
                    factor = startingFactor;
                    product = factor * integer;
                    label2.Text += string.Format("{0} * {1} = {2}\n", integer, factor, product);
                  
                }    
            }

                




        }
    }
}
