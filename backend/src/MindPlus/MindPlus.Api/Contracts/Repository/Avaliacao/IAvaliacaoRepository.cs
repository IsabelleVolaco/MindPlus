using System;
using System.Threading.Tasks;
using MindPlus.Api.Dto.Avaliacao;
using MindPlus.Api.Entity;

namespace MindPlus.Api.Contracts.Repository
{
    public interface IAvaliacaoRepository
    {
        Task <EstatisticasDTO> ObterEstatisticas();
        Task<MetasDTO> ObterMetas();
    }
}
