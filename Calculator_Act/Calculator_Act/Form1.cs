namespace Calculator_Act
{
    public partial class Calculator : Form
    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationPending = false;

        public Calculator()
        {
            InitializeComponent();

            btn7.Paint += button_Paint;
            btn8.Paint += button_Paint;
            btm9.Paint += button_Paint;
            btn4.Paint += button_Paint;
            btn5.Paint += button_Paint;
            btn6.Paint += button_Paint;
            btn1.Paint += button_Paint;
            btn2.Paint += button_Paint;
            btn3.Paint += button_Paint;
            btn0.Paint += button_Paint;
            btnClear.Paint += button_Paint;
            btnEql.Paint += button_Paint;
            btnPlus.Paint += button_Paint;
            btnMin.Paint += button_Paint;
            btnMul.Paint += button_Paint;
            btnDiv.Paint += button_Paint;
        }

        
        
        private void button_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            ControlPaint.DrawBorder(e.Graphics, btn.ClientRectangle,
                SystemColors.ControlDark, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlDark, 5, ButtonBorderStyle.Outset);
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;  
            txtTotal.Text = currentInput;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtTotal.Text = currentInput;
        }


        private void btn9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtTotal.Text = currentInput;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtTotal.Text = currentInput;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtTotal.Text = currentInput;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtTotal.Text = currentInput;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtTotal.Text = currentInput; 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtTotal.Text = currentInput;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtTotal.Text = currentInput;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            operationPending = false;
            txtTotal.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtTotal.Text = currentInput;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (operationPending) Evaluate();

            if (!string.IsNullOrEmpty(currentInput))
                result = double.Parse(currentInput);

            operation = "+";
            currentInput = "";
            operationPending = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (operationPending) Evaluate();

            if (!string.IsNullOrEmpty(currentInput))
                result = double.Parse(currentInput);

            operation = "-";
            currentInput = "";
            operationPending = true;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (operationPending) Evaluate();

            if (!string.IsNullOrEmpty(currentInput))
                result = double.Parse(currentInput);

            operation = "*";
            currentInput = "";
            operationPending = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (operationPending) Evaluate();

            if (!string.IsNullOrEmpty(currentInput))
                result = double.Parse(currentInput);

            operation = "/";
            currentInput = "";
            operationPending = true;
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void Evaluate()
        {
            if (operationPending && !string.IsNullOrEmpty(currentInput))
            {
                double secondNumber = double.Parse(currentInput);

                switch (operation)
                {
                    case "+": result += secondNumber; break;
                    case "-": result -= secondNumber; break;
                    case "*": result *= secondNumber; break;
                    case "/":
                        if (secondNumber != 0)
                            result /= secondNumber;
                        else
                        {
                            txtTotal.Text = "Error";
                            currentInput = "";
                            operationPending = false;
                            return;
                        }
                        break;
                }

                txtTotal.Text = result.ToString();
                currentInput = txtTotal.Text;
                operationPending = false;
            }
        }


    }
}