namespace Calculator
{

    public partial class Form1 : Form
    {
        public decimal Result { get; set; }
        public decimal Value { get; set; }
        private Operation OperationSelect { get; set; }
        private enum Operation
        {
            Addition,
            Subtraction,
            Multiplication,
            Division
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResult.Text))
            {
                OperationSelect = Operation.Addition;
                Value = Convert.ToDecimal(txtResult.Text);
                txtResult.Text = "";
                lblOperation.Text = "+";
            }
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResult.Text))
            {
                OperationSelect = Operation.Subtraction;
                Value = Convert.ToDecimal(txtResult.Text);
                txtResult.Text = "";
                lblOperation.Text = "-";
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResult.Text))
            {
                OperationSelect = Operation.Multiplication;
                Value = Convert.ToDecimal(txtResult.Text);
                txtResult.Text = "";
                lblOperation.Text = "*";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResult.Text))
            {
                OperationSelect = Operation.Division;
                Value = Convert.ToDecimal(txtResult.Text);
                txtResult.Text = "";
                lblOperation.Text = "/";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (OperationSelect)
            {
                case Operation.Addition:
                    Result = Value + Convert.ToDecimal(txtResult.Text);
                    break;
                case Operation.Subtraction:
                    Result = Value - Convert.ToDecimal(txtResult.Text);
                    break;
                case Operation.Division:
                    Result = Value / Convert.ToDecimal(txtResult.Text);
                    break;
                case Operation.Multiplication:
                    Result = Value * Convert.ToDecimal(txtResult.Text);
                    break;
            }
            txtResult.Text = Convert.ToString(Result);
            Value = Result;
            lblOperation.Text = "=";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains(","))
                txtResult.Text += ",";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            lblOperation.Text = "";
        }
    }
}