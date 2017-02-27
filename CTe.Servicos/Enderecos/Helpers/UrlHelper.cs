﻿using System;
using DFe.Classes.Entidades;
using DFe.Classes.Flags;

namespace CTeDLL.Servicos.Enderecos.Helpers
{
    public class UrlHelper
    {
        public static UrlCTe ObterUrlServico()
        {
            var configuracaoServico = ConfiguracaoServico.Instancia;

            switch (configuracaoServico.tpAmb)
            {
                case TipoAmbiente.Homologacao:
                    return UrlHomologacao();
            }

            // todo fazer urls para produção ainda
            return null;
        }

        private static UrlCTe UrlHomologacao()
        {
            var configuracaoServico = ConfiguracaoServico.Instancia;

            switch (configuracaoServico.cUF)
            {
                case Estado.MT:
                    return new UrlCTe
                    {
                        CteStatusServico = @"https://homologacao.sefaz.mt.gov.br/ctews/services/CteStatusServico",
                        CteRetRecepcao = @"https://homologacao.sefaz.mt.gov.br/ctews/services/CteRetRecepcao",
                        CteRecepcao = @"https://homologacao.sefaz.mt.gov.br/ctews/services/CteRecepcao",
                        CteInutilizacao = @"https://homologacao.sefaz.mt.gov.br/ctews/services/CteInutilizacao",
                        CteRecepcaoEvento =
                            @"https://homologacao.sefaz.mt.gov.br/ctews2/services/CteRecepcaoEvento?wsdl",
                        CteConsulta = @"https://homologacao.sefaz.mt.gov.br/ctews/services/CteConsulta"
                    };
                case Estado.MS:
                    return new UrlCTe
                    {
                        CteStatusServico = @"https://homologacao.cte.ms.gov.br/ws/CteStatusServico",
                        CteRetRecepcao = @"https://homologacao.cte.ms.gov.br/ws/CteRetRecepcao",
                        CteRecepcao = @"https://homologacao.cte.ms.gov.br/ws/CteRecepcao",
                        CteInutilizacao = @"https://homologacao.cte.ms.gov.br/ws/CteInutilizacao",
                        CteRecepcaoEvento = @"https://homologacao.cte.ms.gov.br/ws/CteRecepcaoEvento",
                        CteConsulta = @"https://homologacao.cte.ms.gov.br/ws/CteConsulta"
                    };
                case Estado.MG:
                    return new UrlCTe
                    {
                        CteStatusServico = @"https://hcte.fazenda.mg.gov.br/cte/services/CteStatusServico?wsdl",
                        CteRetRecepcao = @"https://hcte.fazenda.mg.gov.br/cte/services/CteRetRecepcao?wsdl",
                        CteRecepcao = @"https://hcte.fazenda.mg.gov.br/cte/services/CteRecepcao?wsdl",
                        CteInutilizacao = @"https://hcte.fazenda.mg.gov.br/cte/services/CteInutilizacao?wsdl",
                        CteRecepcaoEvento = @"https://hcte.fazenda.mg.gov.br/cte/services/RecepcaoEvento?wsdl",
                        CteConsulta = @"https://hcte.fazenda.mg.gov.br/cte/services/CteConsulta?wsdl"
                    };
                case Estado.PR:
                    return new UrlCTe
                    {
                        CteStatusServico = @"https://homologacao.cte.fazenda.pr.gov.br/cte/CteStatusServico?wsdl",
                        CteRetRecepcao = @"https://homologacao.cte.fazenda.pr.gov.br/cte/CteRetRecepcao?wsdl",
                        CteRecepcao = @"https://homologacao.cte.fazenda.pr.gov.br/cte/CteRecepcao?wsdl",
                        CteInutilizacao = @"https://homologacao.cte.fazenda.pr.gov.br/cte/CteInutilizacao?wsdl",
                        CteRecepcaoEvento = @"https://homologacao.cte.fazenda.pr.gov.br/cte/CteRecepcaoEvento?wsdl",
                        CteConsulta = @"https://homologacao.cte.fazenda.pr.gov.br/cte/CteConsulta?wsdl"
                    };
                case Estado.RS:
                    return new UrlCTe
                    {
                        CteStatusServico =
                            @"https://cte-homologacao.svrs.rs.gov.br/ws/ctestatusservico/CteStatusServico.asmx",
                        CteRetRecepcao = @"https://cte-homologacao.svrs.rs.gov.br/ws/cteretrecepcao/cteRetRecepcao.asmx",
                        CteRecepcao = @"https://cte-homologacao.svrs.rs.gov.br/ws/cterecepcao/CteRecepcao.asmx",
                        CteInutilizacao =
                            @"https://cte-homologacao.svrs.rs.gov.br/ws/cteinutilizacao/cteinutilizacao.asmx",
                        CteRecepcaoEvento =
                            @"https://cte-homologacao.svrs.rs.gov.br/ws/cterecepcaoevento/cterecepcaoevento.asmx",
                        CteConsulta = @"https://cte-homologacao.svrs.rs.gov.br/ws/cteconsulta/CteConsulta.asmx"
                    };
                case Estado.SP:
                    return new UrlCTe
                    {
                        CteStatusServico =
                            @"https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/cteStatusServico.asmx",
                        CteRetRecepcao =
                            @"https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/cteRetRecepcao.asmx",
                        CteRecepcao = @"https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/cteRecepcao.asmx",
                        CteInutilizacao =
                            @"https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/cteInutilizacao.asmx",
                        CteRecepcaoEvento =
                            @"https://homologacao.nfe.fazenda.sp.gov.br/cteweb/services/cteRecepcaoEvento.asmx",
                        CteConsulta = @"https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/cteConsulta.asmx"
                    };
                case Estado.AC:
                case Estado.AL:
                case Estado.AM:
                case Estado.BA:
                case Estado.CE:
                case Estado.DF:
                case Estado.ES:
                case Estado.GO:
                case Estado.MA:
                case Estado.PA:
                case Estado.PB:
                case Estado.PI:
                case Estado.RJ:
                case Estado.RN:
                case Estado.RO:
                case Estado.SC:
                case Estado.SE:
                case Estado.TO:
                    return new UrlCTe
                    {
                        CteStatusServico =
                            @"https://cte-homologacao.svrs.rs.gov.br/ws/ctestatusservico/CTeStatusServico.asmx",
                        CteConsulta = @"https://cte-homologacao.svrs.rs.gov.br/ws/cteconsulta/CTeConsulta.asmx",
                        CteInutilizacao =
                            @"https://cte-homologacao.svrs.rs.gov.br/ws/cteinutilizacao/cteinutilizacao.asmx",
                        CteRecepcao = @"https://cte-homologacao.svrs.rs.gov.br/ws/cterecepcao/CTeRecepcao.asmx",
                        CteRecepcaoEvento =
                            @"https://cte-homologacao.svrs.rs.gov.br/ws/cterecepcaoevento/CTeRecepcaoEvento.asmx",
                        CteRetRecepcao = @"https://cte-homologacao.svrs.rs.gov.br/ws/cteretrecepcao/CTeRetRecepcao.asmx"
                    };
                case Estado.AP:
                case Estado.PE:
                case Estado.RR:
                    return new UrlCTe
                    {
                        CteStatusServico = @"https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/CteStatusServico.asmx",
                        CteRetRecepcao = @"https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/CteRetRecepcao.asmx",
                        CteRecepcao = @"https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/CteRecepcao.asmx",
                        CteInutilizacao = @"https://nfe.fazenda.sp.gov.br/cteWEB/services/cteInutilizacao.asmx",
                        CteRecepcaoEvento = @"https://cte.sefaz.rs.gov.br/ws/CteRecepcaoEvento/CteRecepcaoEvento.asmx",
                        CteConsulta = @"https://homologacao.nfe.fazenda.sp.gov.br/cteWEB/services/CteConsulta.asmx"
                    };
                default:
                    throw new InvalidOperationException(
                        "Não achei a url do seu estado(uf), tente com outra unidade federativa");
            }
        }
    }
}