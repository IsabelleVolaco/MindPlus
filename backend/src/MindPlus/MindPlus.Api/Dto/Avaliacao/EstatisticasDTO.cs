
namespace MindPlus.Api.Dto.Avaliacao
{
    public class EstatisticasDTO
    {
        //public List<EscoreAvaliacao> EscoreTOTAL { get; set; }
        public List<EscoreAvaliacao> EscoresST { get; set; }
        public List<EscoreAvaliacao> EscoresSP { get; set; }
        public List<EscoreAvaliacao> EscoresRI { get; set; }
    }

    //SG
    class EscoreAvaliacao
    {
        public int MediaEscore { get; set; } //ser� repetido 5 vezes na tela, pois o gr�fico de pizza ir� mostrar 1-5 fatias.
        public int NumeroPessoas { get; set; } //n� de pessoas que atingiram tal m�dia
    }   //[PROBLEMA FLOAT: IF para a m�dia "if > 2.2" ]

    //NE grafico de barra - if escore total< 3 /nivel de estresse = ruim (media de cada prova + media geral das provas de cada pessoa)
    //pode ser separado por niv�is (baixo, medio e alto) ou apenas baixo
    public class NiveisEstresseDTO
    {
        public int EscoreTotal { get; set; }
        public string Classificacao { get; set; } //(baixo, m�dio ou alto)
    }

    //TT grafico linha - media de escore das provas por mes
    public class TendenciasTemporaisDTO
    {
        public int Mes { get; set; }
        public double MediaEscore { get; set; }
    }

    //EVP/P grafico em barra com numero indicando 1-5 - media geral de cada um (ST e SP), compara qual � o maior, e quanto maior �
    public class EquilibrioVidaDTO
    {
        public string Categoria { get; set; }
        public double MediaGeral { get; set; }
    }


}

