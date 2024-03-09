using DietManagerCore.Enums;

namespace DietManagerCore.Requests;

public class BaseLifeStyleInfoRequest
{
    public int Height { get; set; }
    public int Weight { get; set; }
    public LifeStyleEnum LifeStyle { get; set; }
    public int Age { get; set; }
}
