using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultipleImpOneInterface.Api.Enum;
using MultipleImpOneInterface.Api.IService;

namespace MultipleImpOneInterface.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EatController : ControllerBase
    {
        private readonly IEatService animalEatService;
        private readonly IEatService humanEatService;


        public EatController(EatServiceResolver paymentServiceResolver)
        {
            animalEatService = paymentServiceResolver(AnimalType.Animal);
            humanEatService = paymentServiceResolver(AnimalType.Human);
        }

        /// <summary>
        /// 动物
        /// </summary>
        [HttpGet(nameof(AnimalEat))]
        public void AnimalEat(string food)
        {
            animalEatService.Eat(food);
        }

        /// <summary>
        /// 人类
        /// </summary>
        [HttpGet(nameof(HumanEat))]
        public void HumanEat(string food)
        {
            humanEatService.Eat(food);
        }
    }
}
