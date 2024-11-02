using System.Drawing;
using System.Globalization;
using View.Formularios;

namespace View.Controllers
{
    public class FreteController
    {
        public readonly FreteView _freteView;

        public FreteController(FreteView view)
        {
            _freteView = view;

            _freteView.txbValorFrete.TextChanged += OnValorFreteTextChanged;
            _freteView.txbValorFrete.KeyPress += OnValorFreteKeyPress;
        }

        private void OnValorFreteTextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Remove todos os caracteres que não sejam dígitos
            string valorLimpo = txt.Text.Replace(",", "").Replace(".", "").TrimStart('0');

            if (string.IsNullOrEmpty(valorLimpo))
            {
                valorLimpo = "0";
            }

            // Converte o valor em um número decimal
            decimal valor;
            if (decimal.TryParse(valorLimpo, out valor))
            {
                // Divide por 100 para ajustar para o formato de moeda (00,00)
                valor /= 100;
                txt.Text = valor.ToString("N2");
                txt.SelectionStart = txt.Text.Length; // Mantém o cursor no final do texto
            }
        }

        private void OnValorFreteKeyPress(object sender, KeyPressEventArgs e)
        {
            //// Allow only digits, control keys (e.g., backspace), and the decimal separator
            bool isDigit = char.IsDigit(e.KeyChar);
            bool isNumber = char.IsDigit(e.KeyChar);
            bool isControl = char.IsControl(e.KeyChar);
            bool isDecimalSeparator = (e.KeyChar == ',' && !_freteView.txbValorFrete.Text.Contains(","));

            if (!(isControl || isDecimalSeparator || (isNumber && this.IsRange(_freteView.txbValorFrete.Text, e.KeyChar))))
            {
                e.Handled = true; // Ignore the key press if it's not allowed
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                _freteView.Close(); // Fecha o formulário
            }
        }

        private bool IsRange(string text, char newValue)
        {
            decimal MaxValue = 99.99M;
            decimal MinValue = 00.00M;

            text += newValue;
            if (MaxValue == 0 || Convert.ToDecimal(text) >= MinValue && Convert.ToDecimal(text) <= MaxValue)
                return true;
            else
                return false;
        }

    }
}