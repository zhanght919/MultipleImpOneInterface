
using MultipleImpOneInterface.Api.IService;

namespace MultipleImpOneInterface.Api.Service
{
    public class HumanEatService : IEatService
    {
        public void Eat(string food)
        {
            Console.WriteLine($"人类在吃：{food}");
        }
    }
}
