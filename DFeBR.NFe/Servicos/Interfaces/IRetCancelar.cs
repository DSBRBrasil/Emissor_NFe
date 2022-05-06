﻿// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.RetornoServicos.Evento;

#endregion

namespace DFeBR.EmissorNFe.Servicos.Interfaces
{
    public interface IRetCancelar : IRetBasico
    {
        #region Propriedades

        retEnvEvento Retorno { get; set; }

        #endregion
    }
}