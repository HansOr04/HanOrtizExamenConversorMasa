namespace HanOrtizExamenConversorMasa
{
    public class HOConversionModel
    {
        // Properties
        public string UnidadOrigen { get; set; }
        public string UnidadDestino { get; set; }
        public double Valor { get; set; }
        public double Resultado { get; private set; }

        // Constructor
        public HOConversionModel()
        {
            Limpiar();
        }

        // Method to perform the conversion
        public void RealizarConversion()
        {
            // First convert to kilograms as base unit
            double valorEnKg = ConvertirAKilogramos(Valor, UnidadOrigen);
            
            // Then convert from kilograms to target unit
            Resultado = ConvertirDesdeKilogramos(valorEnKg, UnidadDestino);
        }

        // Convert any unit to kilograms
        private double ConvertirAKilogramos(double valor, string unidad)
        {
            return unidad switch
            {
                "Kilogramos" => valor,
                "Libras" => valor * 0.45359237,
                "Onzas" => valor * 0.0283495231,
                _ => throw new ArgumentException("Unidad de origen no válida")
            };
        }

        // Convert from kilograms to any unit
        private double ConvertirDesdeKilogramos(double valorEnKg, string unidad)
        {
            return unidad switch
            {
                "Kilogramos" => valorEnKg,
                "Libras" => valorEnKg / 0.45359237,
                "Onzas" => valorEnKg / 0.0283495231,
                _ => throw new ArgumentException("Unidad de destino no válida")
            };
        }

        // Reset all values
        public void Limpiar()
        {
            UnidadOrigen = string.Empty;
            UnidadDestino = string.Empty;
            Valor = 0;
            Resultado = 0;
        }
    }
}