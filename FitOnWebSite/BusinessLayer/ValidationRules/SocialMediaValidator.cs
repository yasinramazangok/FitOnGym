using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SocialMediaValidator : AbstractValidator<SocialMedia>
    {
        public SocialMediaValidator()
        {
            RuleFor(s => s.Title).NotEmpty().WithMessage("Başlığı boş geçemezsiniz!");
            RuleFor(s => s.Icon).NotEmpty().WithMessage("İcon'u boş geçemezsiniz!");
            RuleFor(s => s.Url).NotEmpty().WithMessage("URL'i boş geçemezsiniz!");
        }
    }
}
