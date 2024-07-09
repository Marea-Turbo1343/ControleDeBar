using ControleDeBar.Dominio._2._1_Compartilhado;
using ControleDeBar.Dominio._2._3_ModuloConta;

namespace ControleDeBar.Dominio._2._5_ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public int Numero { get; set; }
        public Conta Conta { get; set; }

        public Mesa()
        {

        }

        public Mesa(int numero, Conta conta)
        {
            Numero = numero;
            Conta = conta;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
