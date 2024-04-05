using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca2
{
    public static class CalculadoraFinanceira
    {
        public static double Montante(double capital, double taxa, double tempo)
        {
            taxa = taxa / 100.0;
            double montante = capital * (1 + taxa * tempo); 
            return montante;
        }
        public static double Capital(double montante, double taxa, double tempo)
        {
            taxa = taxa / 100.0;
            double capital = montante / (1 + taxa * tempo);
            return capital;
        }
        public static double Juros(double montante, double capital)
        {
            
            double juros = montante - capital;
            return juros;
        }
        public static double Taxa(double montante, double capital, double tempo)
        {

            double taxa = montante - capital / (capital * tempo);
            return taxa/100.0;
        }
        public static double Tempo(double montante, double capital, double taxa)
        {
            taxa = taxa / 100.0;
            double tempo = montante - capital / (capital * taxa);
            return tempo;
        }

    }
}
