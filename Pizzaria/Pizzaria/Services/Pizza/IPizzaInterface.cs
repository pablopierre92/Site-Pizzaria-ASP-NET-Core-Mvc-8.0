using Pizzaria.Dto;
using Pizzaria.Models;

namespace Pizzaria.Services.Pizza
{
	public interface IPizzaInterface
	{
		Task<PizzaModel> CriarPizza(PizzaCriacaoDto pizzaCriacaoDto, IFormFile foto);
		Task<List<PizzaModel>> GetPizzas();
		Task<PizzaModel> GetPizzaPorId(int id);

		Task<PizzaModel> EditarPizza(PizzaModel pizza, IFormFile? foto);
	}
}
