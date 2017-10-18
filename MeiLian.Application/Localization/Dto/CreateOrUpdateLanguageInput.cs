using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace MeiLian.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}
