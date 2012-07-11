using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringTemplateMethod.Original
{
    public class Prestacao
    {
        public decimal Calcular(decimal valorTotal, int numeroDeParcelas)
        {            
            var valorPrincipal = valorTotal / numeroDeParcelas;
  
            var valorDaTaxaAdministrativa = valorPrincipal * 0.01m;

            var valorDoSeguro = valorPrincipal * 0.015m;

            return valorPrincipal + valorDaTaxaAdministrativa + valorDoSeguro;
        }
    }

    public class PrestacaoContratoEspecial
    {
        public decimal Calcular(decimal valorTotal, int numeroDeParcelas)
        {
            var valorPrincipal = valorTotal / numeroDeParcelas;

            var valorDaTaxaAdministrativa = (valorPrincipal * 0.01m) + 1.5m;

            var valorDoSeguro = 0.015m / valorPrincipal + 1;

            return valorPrincipal + valorDaTaxaAdministrativa + valorDoSeguro;
        }
    }
}
