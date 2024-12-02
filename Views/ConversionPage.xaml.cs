using HansOrtizExamenConversorMasa.Models;

namespace HansOrtizExamenConversorMasa.Views
{
    public partial class HOConversionPage : ContentPage
    {
        private readonly HOConversionModel _modelo;

        public HOConversionPage()
        {
            InitializeComponent();
            _modelo = new HOConversionModel();
        }

        private void HOPickerOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HOPickerOrigen.SelectedIndex >= 0)
            {
                _modelo.UnidadOrigen = HOPickerOrigen.SelectedItem.ToString();
                CalcularConversion();
            }
        }

        private void HOPickerDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HOPickerDestino.SelectedIndex >= 0)
            {
                _modelo.UnidadDestino = HOPickerDestino.SelectedItem.ToString();
                CalcularConversion();
            }
        }

        private void HOEntryValor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(HOEntryValor.Text, out double valor))
            {
                _modelo.Valor = valor;
                CalcularConversion();
            }
        }

        private void HOButtonLimpiar_Clicked(object sender, EventArgs e)
        {
            _modelo.Limpiar();
            HOEntryValor.Text = string.Empty;
            HOPickerOrigen.SelectedIndex = -1;
            HOPickerDestino.SelectedIndex = -1;
            HOLabelResultado.Text = "0";
        }

        private void CalcularConversion()
        {
            if (HOPickerOrigen.SelectedIndex == -1 || 
                HOPickerDestino.SelectedIndex == -1 || 
                string.IsNullOrEmpty(HOEntryValor.Text))
            {
                return;
            }

            try
            {
                _modelo.RealizarConversion();
                HOLabelResultado.Text = $"{_modelo.Resultado:F2}";
            }
            catch (Exception ex)
            {
                HOLabelResultado.Text = "Error en la conversión";
                // Aquí podrías agregar logging del error si lo necesitas
            }
        }
    }
}