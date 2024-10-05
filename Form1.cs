namespace AllExamples
{
    public partial class Form1 : Form
    {
        private double firstNum = 0; // Ýlk girilen sayý
        private string sign = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            result.Text += (sender as Button).Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            result.Text += (sender as Button).Text;

        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            result.Text += (sender as Button).Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text += (sender as Button).Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text += (sender as Button).Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            result.Text += (sender as Button).Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text += (sender as Button).Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            result.Text += (sender as Button).Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            result.Text += (sender as Button).Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            result.Text += (sender as Button).Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            result.Text += (sender as Button).Text;

        }
        private void topla_Click(object sender, EventArgs e)

        {
             firstNum = Convert.ToDouble(result.Text);
            sign = (sender as Button).Text;
            result.Text = "";

        }

        private void minus_Click(object sender, EventArgs e)
        {
             firstNum = Convert.ToDouble(result.Text);
             sign = (sender as Button).Text;
             result.Text = " ";

        }

        private void multiplication_Click(object sender, EventArgs e)
        {
             firstNum = Convert.ToDouble(result.Text);
             sign = (sender as Button).Text;
            result.Text = " ";

        }

        private void divide_Click(object sender, EventArgs e)
        {
             firstNum = Convert.ToDouble(result.Text);
             sign = (sender as Button).Text;
            result.Text = " ";

        }
        private void equal_Click(object sender, EventArgs e)
        {
            double SecondNum = Convert.ToDouble(result.Text);
            double resultNum = 0;

            switch (sign)
            {
                case "+":
                    resultNum = firstNum + SecondNum;
                    result.Text = resultNum.ToString();
                    break;
                case "-":
                    resultNum = firstNum - SecondNum;
                    result.Text = resultNum.ToString();
                    break;
                case "x":
                    resultNum = firstNum * SecondNum;
                    result.Text = resultNum.ToString();
                    break;
                case "/":
                    resultNum = firstNum / SecondNum;
                    result.Text = resultNum.ToString();
                    break;
            }




        }
        private void back_Click(object sender, EventArgs e)
        {
            if (result.Text.Length > 0) 
            {

                result.Text = result.Text.Substring(0, result.Text.Length - 1);
             }
        }
    }
}
