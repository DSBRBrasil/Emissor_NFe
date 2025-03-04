﻿// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

#endregion

#region

using DFeBR.EmissorNFe.Utilidade.Tipos;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Identificacao
{
    public class refNFP
    {
        #region Propriedades

        /// <summary>
        ///     BA11 - Código da UF do emitente
        /// </summary>
        public Estado cUF { get; set; }

        /// <summary>
        ///     BA12 - Ano e Mês de emissão da NF-e
        /// </summary>
        public string AAMM { get; set; }

        /// <summary>
        ///     BA13 - CNPJ do emitente
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        ///     BA14 - CPF do emitente
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        ///     BA15 - IE do emitente
        /// </summary>
        public string IE { get; set; }

        /// <summary>
        ///     BA16 - Modelo do Documento Fiscal
        /// </summary>
        public string mod { get; set; }

        /// <summary>
        ///     BA17 - Série do Documento Fiscal
        /// </summary>
        public int serie { get; set; }

        /// <summary>
        ///     BA18 - Número do Documento Fiscal
        /// </summary>
        public int nNF { get; set; }

        #endregion
    }
}