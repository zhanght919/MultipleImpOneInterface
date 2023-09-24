using MultipleImpOneInterface.Api.IService;

namespace MultipleImpOneInterface.Api.Service
{
    public class AnimalEatService : IEatService
    {
        public void Eat(string food)
        {
            Console.WriteLine($"动物在吃：{food}");
        }
    }
}
