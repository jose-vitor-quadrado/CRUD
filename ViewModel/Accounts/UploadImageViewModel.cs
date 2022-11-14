using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModel.Accounts;

public class UploadImageViewModel
{
    [Required(ErrorMessage = "Imagem inválida")]
    public string Base64Image { get; set; } = string.Empty;
}