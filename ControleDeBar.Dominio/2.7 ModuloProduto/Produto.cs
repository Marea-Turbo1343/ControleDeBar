﻿using ControleDeBar.Dominio._2._1_Compartilhado.Extensions;
using ControleDeBar.Dominio._2._1_Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Dominio._2._7_ModuloProduto
{
    public class Produto(string nome, decimal preco) : EntidadeBase
    {
        public string Nome { get; set; } = nome;
        public decimal Preco { get; set; } = preco;

        #region Overrides
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Produto atualizado = (Produto)novoRegistro;
            Nome = atualizado.Nome;
            Preco = atualizado.Preco;
        }
        public override List<string> Validar()
        {
            List<string> erros = [];
            VerificaNulo(ref erros, Nome, "Nome");
            VerificaNulo(ref erros, Preco, "Preço");

            return erros;
        }
        public override string ToString() => Nome.ToTitleCase();
        #endregion
    }
}