using MultipleImpOneInterface.Api.Enum;
using MultipleImpOneInterface.Api.IService;

namespace MultipleImpOneInterface.Api
{
    public delegate IEatService EatServiceResolver(AnimalType key);
}
