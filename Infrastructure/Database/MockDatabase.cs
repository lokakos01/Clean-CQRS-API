using Domain.Models;

namespace Infrastructure.Database
{
    public class MockDatabase
    {
        public List<Dog> Dogs
        {
            get { return allDogs; }
            set { allDogs = value; }
        }

        private static List<Dog> allDogs = new()
        {
            new Dog { Id = Guid.NewGuid(), Name = "Zlatan"},
            new Dog { Id = Guid.NewGuid(), Name = "Dragan"},
            new Dog { Id = Guid.NewGuid(), Name = "Zoran"},
            new Dog { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestDogForUnitTests"}
        };
        public List<Cat> Cats
        {
            get { return allCats; }
            set { allCats = value; }
        }

        private static List<Cat> allCats = new()
        {
           new Cat { Id = Guid.NewGuid(), Name = "Anders", LikesToPlay = true },
           new Cat { Id = Guid.NewGuid(), Name = "Sven", LikesToPlay = false},
           new Cat { Id = Guid.NewGuid(), Name = "Gustav", LikesToPlay = true},
           new Cat { Id = new Guid("87654321-4321-8765-4321-987654321987"), Name = "TestCatForUnitTests", LikesToPlay = true}
        };
        public List<Bird> Birds
        {
            get { return allBirds; }
            set { allBirds = value; }
        }
        private static List<Bird> allBirds = new()
    {
        new Bird { Id = Guid.NewGuid(), Name = "Ronaldo", CanFly = true },
        new Bird { Id = Guid.NewGuid(), Name = "Beckham", CanFly = false },
        new Bird { Id = Guid.NewGuid(), Name = "Ibrahimovic", CanFly = true },
        new Bird { Id = new Guid("11111111-1111-1111-1111-111111111111"), Name = "TestBirdForUnitTests", CanFly = true}
    };
    }
}
