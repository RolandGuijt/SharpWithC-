using Api.Entities;
using Shared.Enums;

namespace Api
{
    public static class PriceCalculator
    {
        private static readonly int _marginPercentage = 40;

        public static int CalculateForEvent(EventEntity eventEntity)
        {
            var price = 0;

            //switch expression using constant pattern, no fall through
            price += eventEntity.MarketingCostType switch
            {
                CostType.Cheap => 8,
                CostType.Moderate => 10,
                CostType.Expensive => 12,
                _ => throw new ArgumentOutOfRangeException()
            };

            price += eventEntity.VenueCostType switch
            {
                CostType.Cheap => 4,
                CostType.Moderate => 6,
                CostType.Expensive => 10,
                _ => throw new ArgumentOutOfRangeException()
            };

            switch (eventEntity)
            {
                //type pattern
                case MultiDayConferenceEntity e:
                    price += e.BadgeCosts + e.CateringCosts;
                    price += e.AccomodationCostType switch
                    {
                        CostType.Cheap => 50,
                        CostType.Moderate => 80,
                        CostType.Expensive => 110,
                        _ => throw new ArgumentOutOfRangeException()
                    };
                    //Relational pattern as opposed to the old switch syntax or combining it with var pattern
                    price += e.NumberOfDays switch
                    {
                        //pre C# 9
                        //var p when p < 3 => price * e.NumberOfDays,
                        < 3 => price * e.NumberOfDays,
                        //conjunctive pattern
                        >= 3 and < 6 => 200,
                        >= 6 => 360
                    };
                    break;
                case ConferenceEntity e:
                    price += e.BadgeCosts + e.CateringCosts;
                    break;
                case ConcertEntity e:
                    price +=
                    e.ArtistCosts / e.Capacity;
                    price += e.ArtistCostType switch
                    {
                        CostType.Cheap => 5,
                        CostType.Moderate => 8,
                        CostType.Expensive => 11,
                        _ => throw new ArgumentOutOfRangeException()
                    };
                    break;
                case SportsGameEntity e:
                    price += e.Capacity switch
                    {
                        < 100 => e.NumberOfPlayers * e.CostsPerPlayer / e.Sold,
                        //can't use relational pattern here: everything in the expression must be a constant
                        var c when c >= 100 && (c < 150 || e.CostsPerPlayer > 1000) => 100,
                        >= 150 => e.NumberOfPlayers * e.CostsPerPlayer / 200
                    };
                    break;
                //not null pattern
                case not null:
                    throw new ArgumentException($"Unknown entity type", nameof(eventEntity));
                case null:
                    throw new ArgumentNullException(nameof(eventEntity));
            }

            price += (price / 100) * _marginPercentage;
            return price;
        }
    }
}