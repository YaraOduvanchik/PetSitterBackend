﻿using CSharpFunctionalExtensions;
using PetSitter.Domain.Common;
using Entity = PetSitter.Domain.Common.Entity;

namespace PetSitter.Domain.Entities;

public class Disease : Entity 
{
    private Disease()
    {
    }

    private Disease(string name, string symptom)
    {
        Name = name;
        Symptom = symptom;
    }
    
    public string Name { get; private set; }
    public string Symptom { get; private set; }

    public static Result<Disease, Error> Create(string name, string symptom)
    {
        name = name.Trim();
        symptom = symptom.Trim();

        if (string.IsNullOrWhiteSpace(name))
            return Errors.General.ValueIsInvalid(name);

        if (string.IsNullOrWhiteSpace(symptom))
            return Errors.General.ValueIsInvalid(symptom);
        
        return new Disease(name, symptom);
    }
}