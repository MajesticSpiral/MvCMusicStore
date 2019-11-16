using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MvcMusicStore.Models;

namespace MvcMusicStore.ViewModels
{
	public class ShoppingCartViewModel
	{
		[Key]
		public int cartId {get; set;}
		 public List<Cart> CartItems { get; set; }
		public decimal CartTotal { get; set; }
	}
}