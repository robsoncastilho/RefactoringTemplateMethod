using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringTemplateMethod.TemplateMethod
{
    public abstract class Prestacao
    {
        protected decimal _valorPrincipal;
        protected decimal _valorDaTaxaAdministrativa;
        protected decimal _valorDoSeguro;

        public decimal Calcular(decimal valorTotal, int numeroDeParcelas)
        {
            CalcularValorPrincipal(valorTotal, numeroDeParcelas);
            CalcularValorDaTaxaAdministrativa();
            CalcularValorDoSeguro();
            return CalcularValorTotal();
        }

        protected virtual void CalcularValorPrincipal(decimal valorTotal, int numeroDeParcelas)
        {
            _valorPrincipal = valorTotal / numeroDeParcelas;
        }

        protected abstract void CalcularValorDaTaxaAdministrativa();
        protected abstract void CalcularValorDoSeguro();

        protected virtual decimal CalcularValorTotal()
        {
            return _valorPrincipal + _valorDaTaxaAdministrativa + _valorDoSeguro;
        }
    }

    public class PrestacaoContratoPadrao : Prestacao
    {
        protected override void CalcularValorDaTaxaAdministrativa()
        {
            _valorDaTaxaAdministrativa = _valorPrincipal * 0.01m;
        }

        protected override void CalcularValorDoSeguro()
        {
            _valorDoSeguro = _valorPrincipal * 0.015m;
        }
    }

    public class PrestacaoContratoEspecial : Prestacao
    {
        protected override void CalcularValorDaTaxaAdministrativa()
        {
            _valorDaTaxaAdministrativa = (_valorPrincipal * 0.01m) + 1.5m;
        }

        protected override void CalcularValorDoSeguro()
        {
            _valorDoSeguro = 0.015m / _valorPrincipal + 1;
        }
    }
}
