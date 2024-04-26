﻿using Microsoft.EntityFrameworkCore;
using Pizzaria.Models;

namespace Pizzaria.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext>options) : base (options)
		{

		}

		public DbSet<PizzaModel> Pizzas {  get; set; }
	}
}
