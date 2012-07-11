using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefactoringTemplateMethod.Original;

namespace RefactoringTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {            
            // classes originais
            var prestacao = new Prestacao();
            var valor = prestacao.Calcular(10000m, 100);
            Console.WriteLine("Valor calculado: {0:C}", valor);

            var prestacaoContratoEspecial = new PrestacaoContratoEspecial();
            valor = prestacaoContratoEspecial.Calcular(10000m, 100);
            Console.WriteLine("Valor calculado: {0:C}", valor);

            // classes refatoradas
            var prestacaoRefatorada = new Refatorado.Prestacao();
            valor = prestacaoRefatorada.Calcular(10000m, 100);
            Console.WriteLine("Valor calculado: {0:C}", valor);

            var prestacaoRefatoradaEspecial = new Refatorado.PrestacaoContratoEspecial();
            valor = prestacaoRefatoradaEspecial.Calcular(10000m, 100);
            Console.WriteLine("Valor calculado: {0:C}", valor);

            // classes com o padrao TemplateMethod
            var prestacaoPadrao = new TemplateMethod.PrestacaoContratoPadrao();
            valor = prestacaoPadrao.Calcular(10000m, 100);
            Console.WriteLine("Valor calculado: {0:C}", valor);

            var prestacaoEspecial = new TemplateMethod.PrestacaoContratoEspecial();
            valor = prestacaoEspecial.Calcular(10000m, 100);
            Console.WriteLine("Valor calculado: {0:C}", valor);

        }
    }
}
