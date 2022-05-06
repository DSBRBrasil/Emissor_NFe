﻿// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using System.Xml.Serialization;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using DFeBR.EmissorNFe.Utilidade;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Estadual
{
    public class ICMS20 : ICMSBasico
    {
        #region Propriedades

        /// <summary>
        ///     N11 - Origem da Mercadoria
        /// </summary>
        [XmlElement(Order = 1)]
        public OrigemMercadoria orig { get; set; }

        /// <summary>
        ///     N12- Situação Tributária
        /// </summary>
        [XmlElement(Order = 2)]
        public Csticms CST { get; set; }

        /// <summary>
        ///     N13 - Modalidade de determinação da BC do ICMS
        /// </summary>
        [XmlElement(Order = 3)]
        public DeterminacaoBaseIcms modBC { get; set; }

        /// <summary>
        ///     N14 - Percentual de redução da BC
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal pRedBC
        {
            get => _pRedBc.Arredondar(4);
            set => _pRedBc = value.Arredondar(4);
        }

        /// <summary>
        ///     N15 - Valor da BC do ICMS
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal vBC
        {
            get => _vBc.Arredondar(2);
            set => _vBc = value.Arredondar(2);
        }

        /// <summary>
        ///     N16 - Alíquota do imposto
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal pICMS
        {
            get => _pIcms.Arredondar(4);
            set => _pIcms = value.Arredondar(4);
        }

        /// <summary>
        ///     N17 - Valor do ICMS
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal vICMS
        {
            get => _vIcms.Arredondar(2);
            set => _vIcms = value.Arredondar(2);
        }

        /// <summary>
        ///     N17a - Valor da Base de Cálculo do FCP
        ///     Versão 4.00
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal? vBCFCP
        {
            get => _vBcfcp.Arredondar(2);
            set => _vBcfcp = value.Arredondar(2);
        }

        public bool vBCFCPSpecified => vBCFCP.HasValue;

        /// <summary>
        ///     N17b - Percentual do Fundo de Combate à Pobreza (FCP)
        ///     Versão 4.00
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal? pFCP
        {
            get => _pFcp.Arredondar(4);
            set => _pFcp = value.Arredondar(4);
        }

        public bool pFCPSpecified => pFCP.HasValue;

        /// <summary>
        ///     N17c - Valor do Fundo de Combate à Pobreza (FCP)
        ///     Versão 4.00
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal? vFCP
        {
            get => _vFcp.Arredondar(2);
            set => _vFcp = value.Arredondar(2);
        }

        public bool vFCPSpecified => vFCP.HasValue;

        /// <summary>
        ///     N27a - Valor do ICMS desonerado
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal? vICMSDeson
        {
            get => _vIcmsDeson.Arredondar(2);
            set => _vIcmsDeson = value.Arredondar(2);
        }

        /// <summary>
        ///     N28 - Motivo da desoneração do ICMS
        /// </summary>
        [XmlElement(Order = 12)]
        public MotivoDesoneracaoIcms? motDesICMS { get; set; }

        #endregion

        public bool ShouldSerializevICMSDeson()
        {
            return vICMSDeson.HasValue;
        }

        public bool ShouldSerializemotDesICMS()
        {
            return motDesICMS.HasValue;
        }

        private decimal? _pFcp;
        private decimal _pIcms;
        private decimal _pRedBc;
        private decimal _vBc;
        private decimal? _vBcfcp;
        private decimal? _vFcp;
        private decimal _vIcms;
        private decimal? _vIcmsDeson;
    }
}