﻿using Petfolio.Communication.Response;

namespace Petfolio.Application.UseCases.Pets.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            Pets = [
                new ResponseShortPetJson
                {
                    Id = 1,
                    Name = "Cachorrinho",
                    Type = Communication.Enums.PetType.Dog
                },
                new ResponseShortPetJson
                {
                    Id = 2,
                    Name = "Gatinho",
                    Type = Communication.Enums.PetType.Cat
                },
            ]
        };
    }
}
