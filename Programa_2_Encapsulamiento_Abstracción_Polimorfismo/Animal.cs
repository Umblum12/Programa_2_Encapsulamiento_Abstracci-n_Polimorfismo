using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_2_Encapsulamiento_Abstracción_Polimorfismo
{
    internal class Animal
    {
        string nombre;
        int total_patas;
        string sonido_emitido;
        string Dormir;
        public string Nombre { get => nombre; set => nombre = value; }
        public int Total_patas { get => total_patas; set => total_patas = value; }
        public string Sonido_emitido { get => sonido_emitido; set => sonido_emitido = value; }
        public string Dormir1 { get => Dormir; set => Dormir = value; }
    }
}
