using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double number_1, number_2;
        public string operator_;

        private void digit_Click(object sender, EventArgs e)
        {
            string enteredDigit = ((Button)sender).Text;

            bool isOnlyZeros = textBox1.Text.All(c => c == '0' || c == ',');

            if (isOnlyZeros && enteredDigit != ",")
            {
                textBox1.Text = enteredDigit;
            }
            else
            {
                textBox1.Text += enteredDigit;
            }

            error.Text = string.Empty;
        }

        private void Action_Click(object sender, EventArgs e)
        {
            try
            {
                // Выполняем накопительное вычисление, если number_1 уже был установлен
                if (!string.IsNullOrEmpty(operator_) && !string.IsNullOrEmpty(textBox1.Text))
                {
                    number_2 = Convert.ToDouble(textBox1.Text);
                    PerformCalculation();
                }

                // Сохраняем текущее число и оператор для следующего вычисления
                number_1 = Convert.ToDouble(textBox1.Text);
                operator_ = ((Button)sender).Text;

                // Очищаем поле ввода
                textBox1.Text = string.Empty;
            }
            catch (Exception ex)
            {
                error.Text = $"Ошибка: {ex.Message}";
            }
        }

        private void PerformCalculation()
        {
            switch (operator_)
            {
                case "+":
                    textBox1.Text = ((number_1 + number_2) % (int)Math.Pow(10, 3)).ToString();
                    break;
                case "-":
                    textBox1.Text = ((number_1 - number_2) % (int)Math.Pow(10, 3)).ToString();
                    break;
                case "*":
                    textBox1.Text = ((number_1 * number_2) % (int)Math.Pow(10, 3)).ToString();
                    break;
                case "/":
                    if (number_2 == 0)
                    {
                        error.Text = "Ошибка: деление на ноль";
                        return;
                    }
                    textBox1.Text = ((number_1 / number_2) % (int)Math.Pow(10, 3)).ToString();
                    break;
                case "%":
                    textBox1.Text = (((number_2 / 100) * number_1) % (int)Math.Pow(10, 3)).ToString();
                    break;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            number_1 = 0;
            error.Text = string.Empty;
        }

        private void sum_Click(object sender, EventArgs e)
        {
            try
            {
                number_2 = Convert.ToDouble(textBox1.Text);

                switch (operator_)
                {
                    case "+":
                        textBox1.Text = ((number_1 + number_2) % (int)Math.Pow(10, 3)).ToString();
                        break;
                    case "-":
                        textBox1.Text = ((number_1 - number_2) % (int)Math.Pow(10, 3)).ToString();
                        break;
                    case "*":
                        textBox1.Text = ((number_1 * number_2) % (int)Math.Pow(10, 3)).ToString();
                        break;
                    case "/":
                        if (number_2 == 0)
                        {
                            error.Text = "Ошибка: деление на ноль";
                            return;
                        }
                        textBox1.Text = ((number_1 / number_2) % (int)Math.Pow(10, 3)).ToString();
                        break;
                    case "%":
                        textBox1.Text = (((number_2 / 100) * number_1) % (int)Math.Pow(10, 3)).ToString();
                        break;
                }

            }
            catch (Exception ex)
            {
                error.Text = $"Ошибка: {ex.Message}";
            }
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(','))
                return;

            if (textBox1.Text.Length == 0)
            {
                textBox1.Text += "0,";
                return;
            }


            textBox1.Text += ',';

        }

        private void DEL_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void change_p(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);

            // Меняем знак числа
            number = -number;

            // Возвращаем обратно в textBox1
            textBox1.Text = number.ToString();
        }
    }
}
