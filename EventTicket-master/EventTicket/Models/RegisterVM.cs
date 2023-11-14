using System.ComponentModel.DataAnnotations;

namespace EventTicket.Models
{
	public class RegisterVM
	{
		[Required]
		public string Name { get; set; }

		[Required]
		public string UserName { get; set; }

		[Required]
		public string Email { get; set; }

		[Required]
		public string Password { get; set; }
	}
}