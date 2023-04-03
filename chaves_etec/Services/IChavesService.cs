using chaves_etec.Models;
namespace chaves_etec.Services;

    public interface IChavesService
    {
        List<Personagem> GetPersonagens();
        Personagem GetPersonagem(int Numero);
        ChavesDto GetChavesDto();
        DetailsDto GetDetailedPersonagem(int numero);
    }
