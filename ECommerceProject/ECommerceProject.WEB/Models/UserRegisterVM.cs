using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.WEB.Models
{
	public class UserRegisterVM
	{
		[Required(ErrorMessage="Lütfen Adınızı Giriniz")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
		public string? Surname { get; set; }

		[Required(ErrorMessage = "Lütfen Kullanizi Adini Giriniz")]
		public string? Username { get; set; }

		[Required(ErrorMessage = "Lütfen Mailinizi Giriniz")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Lütfen Sifrenizi Giriniz")]
		public string? Password { get; set; }

		[Required(ErrorMessage = "Lütfen Sifrenizi Tekrar Giriniz")]
		[Compare("Password",ErrorMessage ="Sifreler Uyumlu Değil")]
		public string? ConfirmPassword { get; set; }
	}
}
