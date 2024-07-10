using ControleDeBar.Dominio._2._1_Compartilhado;
using ControleDeBar.Dominio._2._3_ModuloConta;

namespace ControleDeBar.Dominio._2._5_ModuloMesa
{
    public class Mesa() : EntidadeBase
    {
        public decimal Numero { get; set; }

        public Mesa(decimal numero) : this()
        {
            Numero = numero;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Mesa atualizado = (Mesa)novoRegistro;
            Numero = atualizado.Numero;
        }
        public override List<string> Validar()
        {
            List<string> erros = [];

            VerificaNulo(ref erros, Numero, "Número da mesa");

            return erros;
        }
        public override string ToString() => $"Mesa nº {Numero}";
    }
}
