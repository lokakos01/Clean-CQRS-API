﻿using Domain.Models;
using Infrastructure.Database;
using MediatR;



namespace Application.Queries.Birds.GetById
{
    // En klass som implementerar gränssnittet IRequestHandler för att hantera frågan att hämta en fågel efter ett specifikt ID
    public class GetBirdByIdQueryHandler : IRequestHandler<GetBirdByIdQuery, Bird>
    {
        // Ett privat fält för att lagra en mockad databas
        private readonly MockDatabase _mockDatabase;

        // En konstruktor som tar en instans av MockDatabase som parameter och tilldelar det privata fältet
        public GetBirdByIdQueryHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }

        // En metod som implementerar hanteringen av frågan
        public Task<Bird> Handle(GetBirdByIdQuery request, CancellationToken cancellationToken)
        {
            // Används LINQ för att söka efter fågeln med det önskade ID:t i den mockade databasen
            Bird wantedBird = _mockDatabase.Birds.FirstOrDefault(bird => bird.Id == request.Id)!;

            // Returnera resultatet som en uppgift
            return Task.FromResult(wantedBird);
        }
    }
}
