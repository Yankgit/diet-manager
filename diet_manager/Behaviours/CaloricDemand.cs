using DietManagerCore.Enums;
using DietManagerCore.Requests;

namespace DietManagerCore.Behaviours;

public class CaloricDemand
{
    public double WomenCaloricDemand(BaseLifeStyleInfoRequest request)
    {
        double WomenDemand = (10 * request.Weight) + (6.25 * request.Height) + (5 * request.Age) - 161;
        if (request.LifeStyle == LifeStyleEnum.NonActiveLifeStyle)
        {
            return WomenDemand;
        }
        else if (request.LifeStyle == LifeStyleEnum.AvarageActiveLifeStyle)
        {
            return WomenDemand + 250;
        }
        else
        {
            return WomenDemand + 500;
        }
    }

    public double ManCaloricDemand(BaseLifeStyleInfoRequest request)
    {
        double ManDemand = (10 * request.Weight) + (6.25 * request.Height) + (5 * request.Age) + 5;
        if (request.LifeStyle == LifeStyleEnum.NonActiveLifeStyle)
        {
            return ManDemand;
        }
        else if (request.LifeStyle == LifeStyleEnum.AvarageActiveLifeStyle)
        {
            return ManDemand + 250;
        }
        else
        {
            return ManDemand + 500;
        }
    }
}
