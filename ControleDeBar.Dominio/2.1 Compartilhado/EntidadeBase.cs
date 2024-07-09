using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Dominio._2._1_Compartilhado
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }

        public abstract void AtualizarRegistro(EntidadeBase novoRegistro);
        public abstract List<string> Validar();

        //verificar se as validações vão aqui

        #region Validações

        //protected void VerificaNulo(ref List<string> erros, string campoTestado, string mostraCampo)
        //{
        //    if (string.IsNullOrEmpty(campoTestado))
        //        erros.Add($"\nO campo \"{mostraCampo}\" é obrigatório. Tente novamente ");
        //}
        //protected void VerificaNulo(ref List<string> erros, decimal campoTestado, string mostraCampo)
        //{
        //    if (campoTestado == 0)
        //        erros.Add($"\nO campo \"{mostraCampo}\" é obrigatório. Tente novamente ");
        //}
        //protected void VerificaNulo(ref List<string> erros, int campoTestado, string mostraCampo)
        //{
        //    if (string.IsNullOrEmpty(campoTestado.ToString()))
        //        erros.Add($"\nO campo \"{mostraCampo}\" é obrigatório. Tente novamente ");
        //}
        //protected void VerificaNulo(ref List<string> erros, DateTime campoTestado, string mostraCampo)
        //{
        //    if (string.IsNullOrEmpty(campoTestado.ToString()))
        //        erros.Add($"\nO campo \"{mostraCampo}\" é obrigatório. Tente novamente ");
        //}
        //protected void VerificaNulo(ref List<string> erros, TimeSpan campoTestado, string mostraCampo)
        //{
        //    if (campoTestado == TimeSpan.Zero)
        //        erros.Add($"\nO campo \"{mostraCampo}\" é obrigatório. Tente novamente ");
        //}
        //protected void VerificaNulo(ref List<string> erros, EntidadeBase entidade, string mostraCampo)
        //{
        //    if (entidade == null)
        //        erros.Add($"\nO campo \"{mostraCampo}\" é obrigatório. Tente novamente ");
        //}

        #endregion
    }
}
