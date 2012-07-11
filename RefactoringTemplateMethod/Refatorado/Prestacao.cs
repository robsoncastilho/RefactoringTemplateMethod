using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringTemplateMethod.Refatorado
{
    public class Prestacao
    {
        private decimal _valorPrincipal;
        private decimal _valorDaTaxaAdministrativa;
        private decimal _valorDoSeguro;

        public decimal Calcular(decimal valorTotal, int numeroDeParcelas)
        {            
            CalcularValorPrincipal(valorTotal, numeroDeParcelas);
            CalcularValorDaTaxaAdministrativa();
            CalcularValorDoSeguro();
            return CalcularValorTotal();
        }

        private void CalcularValorPrincipal(decimal valorTotal, int numeroDeParcelas)
        {
            _valorPrincipal = valorTotal / numeroDeParcelas;
        }

        private void CalcularValorDaTaxaAdministrativa()
        {
            _valorDaTaxaAdministrativa = _valorPrincipal * 0.01m;
        }

        private void CalcularValorDoSeguro()
        {
            _valorDoSeguro = _valorPrincipal * 0.015m;
        }

        private decimal CalcularValorTotal()
        {
            return _valorPrincipal + _valorDaTaxaAdministrativa + _valorDoSeguro;
        }
    }

    public class PrestacaoContratoEspecial
    {
        private decimal _valorPrincipal;
        private decimal _valorDaTaxaAdministrativa;
        private decimal _valorDoSeguro;

        public decimal Calcular(decimal valorTotal, int numeroDeParcelas)
        {
            CalcularValorPrincipal(valorTotal, numeroDeParcelas);
            CalcularValorDaTaxaAdministrativa();
            CalcularValorDoSeguro();
            return CalcularValorTotal();         
        }

        private void CalcularValorPrincipal(decimal valorTotal, int numeroDeParcelas)
        {
            _valorPrincipal = valorTotal / numeroDeParcelas;
        }

        private void CalcularValorDaTaxaAdministrativa()
        {
            _valorDaTaxaAdministrativa = (_valorPrincipal * 0.01m) + 1.5m;
        }

        private void CalcularValorDoSeguro()
        {
            _valorDoSeguro = 0.015m / _valorPrincipal + 1;
        }

        private decimal CalcularValorTotal()
        {
            return _valorPrincipal + _valorDaTaxaAdministrativa + _valorDoSeguro;
        }
    }
}
