using DietManagerCore.Enums;

namespace DietManagerCore.Responses;

public class BaseLifeStyleInfoResponse
{
    public int Height { get; set; }
    public int Weight { get; set; }
    public string LifeStyle { get; set; }
    public int Age { get; set; }
}
