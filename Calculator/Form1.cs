namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultV = 0;
        String operation = "";
        bool isOperation = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            
               
            if ((textBox.Text == "0") || (isOperation))
            {
                textBox.Clear();
            }
            
            isOperation = false;
            Button button = (Button)sender;
            
            if (button.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text = textBox.Text + button.Text;
                }
            
            }
            else { textBox.Text = textBox.Text + button.Text; }

            if (textBoxT.Text.Contains("=")) 
            { 
                textBoxT.Text = "";
                textBox.Text = button.Text;
            }
        }

        private void operatot_click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operation) && !isOperation)
            {
                buttonE_Click(sender, e);
            }

            Button button = (Button)sender;
            operation = button.Text;
            resultV = Double.Parse(textBox.Text);
            textBoxT.Text = resultV + " " +operation;
            isOperation = true;
           
        }

        private void btn_clear(object sender, EventArgs e)
        {
            textBox.Text = "0";
            textBoxT.Text = "";
            resultV = 0;
        }

        private void btnclick_C(object sender, EventArgs e)
        {
            textBox.Text = "0";
            
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBoxT.Text = resultV + " + " + textBox.Text + " =";
                    textBox.Text = (resultV + Double.Parse(textBox.Text)).ToString();
                    
                    break;

                case "-":
                    textBoxT.Text = resultV + " - " + textBox.Text + " =";
                    textBox.Text = (resultV - Double.Parse(textBox.Text)).ToString();
                    break;

                case "*":
                    textBoxT.Text = resultV + " * " + textBox.Text + " =";
                    textBox.Text = (resultV * Double.Parse(textBox.Text)).ToString();
                    break;

                case "/":

                    textBoxT.Text = resultV + " / " + textBox.Text + " =";
                    if (Double.Parse(textBox.Text) == 0)
                    {  textBox.Text = "err 0"; }
                    else
                    {
                        textBox.Text = (resultV / Double.Parse(textBox.Text)).ToString();
                        
                    }
                    break;
                default:
                    break;



            }
            //resultV = Double.Parse(textBox.Text);
            //textBoxT.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
