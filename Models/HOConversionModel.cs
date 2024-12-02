using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanOrtizExamenConversorMasa.Models
{
    public class HOConversionModel
    {
        public double Valor {  get; set; }
        public string UnidadOrigen { get; set; }
        public string UnidadDestino { get; set; }
        public double Resultado { get; set; }
        public HOConversionModel()
        {
            UnidadOrigen = string.Empty;
            UnidadDestino = string.Empty;
        }
        public void RealizarConversion() {
            double valorEnKG = UnidadOrigen switch
            {
                "Kilogramos" => Valor,
                "Libras" => Valor * 0.45359237,
                "Onzas" => Valor * 0.283495231,
                _ => throw new ArgumentException("Unidad de origen no valida")

            };
            Resultado = UnidadDestino switch
            {
                "Kilogramos" => valorEnKG,
                "Libras" => valorEnKG / 0.45359237,
                "Onzas" => valorEnKG / 0.283495231,
                _ => throw new ArgumentException("Unidad de destino no valida")
            };
        }
        public void Limpiar()
        {
            Valor = 0;
            UnidadOrigen = string.Empty;
            UnidadDestino = string.Empty;
            Resultado = 0;
        }
    }
}
