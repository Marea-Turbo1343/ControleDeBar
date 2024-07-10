using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Dominio._2._1_Compartilhado.Extensions
{
    public interface IControladorContasAbertas
    {
        string ToolTipContasAbertas { get; }
        string ToolTipFecharConta { get; }

        void CarregarContasEmAberto();
        void FecharConta();
    }
}
