using Petfolio.Communication.Response;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        var dados = new ResponsePetJson
        {
            Id = id,
            Name = "Béchano Meau",
            Type = Communication.Enums.PetType.Cat,
            Birthday = new DateTime(year: 2023, month: 03, day: 16),
        };

        return dados;
    }
}