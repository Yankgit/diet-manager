using DietManagerCore.Requests;
using DietManagerCore.Responses;

namespace DietManagerCore.Behaviours;

public class BaseLifeStyleInfoBehaviour
{
    public BaseLifeStyleInfoResponse TriggerAction(BaseLifeStyleInfoRequest request)
    {
        BaseLifeStyleInfoResponse response = new()
        {
            Height = request.Height,
            LifeStyle = request.LifeStyle.ToString(),
            Weight = request.Weight,
        };

        return response;
    }
}
