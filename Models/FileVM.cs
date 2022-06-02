using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using Task5FileExtensionValidation.Models.ValidationAttributes;

namespace Task5FileExtensionValidation.Models
{
    public class FileVM
    {
        [Required]
        [FileExtens(".txt", ".docx")]
        [Display(Name = "Single File Upload (txt,docx)")]
        public IFormFile SingleFile { get; set; }


        [Required]
        [FileExtens(".txt", ".docx")]
        [Display(Name = "Multiple File Upload (txt,docx)")]
        public IFormFile[] MultipleFiles { get; set; }
    }
}
