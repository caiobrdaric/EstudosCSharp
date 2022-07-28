using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Treinamento.ConsoleAppDemo.Model
{
    public class Trabalhador
    {
        public void AcrescentaBonus(double bonus)
        {
            salario = salario + bonus;   
        }

        public double salario { get; set; }
        public string nome { get; set; }
    }
}
