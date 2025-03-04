﻿// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using System;
using System.Xml.Serialization;
using DFeBR.EmissorNFe.Utilidade;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe
{
    public class rastro
    {
        #region Propriedades

        /// <summary>
        ///     I81 - Número do Lote do produto
        ///     Versão 4.0
        /// </summary>
        public string nLote { get; set; }

        /// <summary>
        ///     I82 - Quantidade de produto no Lote
        ///     Versão 4.0
        /// </summary>
        public decimal qLote
        {
            get => _qLote.Arredondar(3);
            set => _qLote = value.Arredondar(3);
        }

        /// <summary>
        ///     I83 - Data de fabricação/ Produção
        ///     Versão 4.0
        /// </summary>
        [XmlIgnore]
        public DateTime dFab { get; set; }

        [XmlElement("dFab")]
        public string ProxydFab
        {
            get => dFab.ParaDataString();
            set => dFab = DateTime.Parse(value);
        }

        /// <summary>
        ///     I84 - Data de validade
        ///     Versão 4.0
        /// </summary>
        [XmlIgnore]
        public DateTime dVal { get; set; }

        [XmlElement("dVal")]
        public string ProxydVal
        {
            get => dVal.ParaDataString();
            set => dVal = DateTime.Parse(value);
        }

        /// <summary>
        ///     I85 - Código de Agregação
        ///     Versão 4.0
        /// </summary>
        public string cAgreg { get; set; }

        #endregion

        private decimal _qLote;
    }
}