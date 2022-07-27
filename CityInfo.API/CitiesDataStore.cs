using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Paris",
                    Description = "The city of love and baguette.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Louvre",
                            Description = "The Famous Museum in Paris."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Eiffel Tower",
                            Description = "The Famous Metallic Tower of Paris."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "London",
                    Description = "Fish and Chips all day long.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "The Big Eye",
                            Description = "The wheel of South Bank."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "The Big Ben",
                            Description = "The striking clock of the Palace of Westminster."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "New York",
                    Description = "The Big Apple just a mouth away.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Broadway Theatre",
                            Description = "The most famous theatre in the world."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Madison Square",
                            Description = "A square full of lights which the fame came from."
                        }
                    }
                }
            };
        }
    }
}
