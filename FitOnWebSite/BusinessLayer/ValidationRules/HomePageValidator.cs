using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class HomePageValidator : AbstractValidator<HomePage>
    {
        public HomePageValidator()
        {
            RuleFor(h => h.TagLine).NotEmpty().WithMessage("Üst bilgiyi boş geçemezsiniz!");
            RuleFor(h => h.TagLine1).NotEmpty().WithMessage("Üst bilgi 1'i boş geçemezsiniz!");
            RuleFor(h => h.TagLine2).NotEmpty().WithMessage("Üst bilgi 2'yi boş geçemezsiniz!");
            RuleFor(h => h.TagLine3).NotEmpty().WithMessage("Üst bilgi 3'ü boş geçemezsiniz!");
            RuleFor(h => h.ImageUrl).NotEmpty().WithMessage("Görsel yolunu boş geçemezsiniz!");
            RuleFor(h => h.ImageUrl1).NotEmpty().WithMessage("Görsel yolu 1'i boş geçemezsiniz!");
            RuleFor(h => h.TagLine1).MinimumLength(10).WithMessage("Üst bilgi 1 en az 10 karakter olmalıdır!");
            RuleFor(h => h.TagLine3).MinimumLength(10).WithMessage("Üst bilgi 3 en az 10 karakter olmalıdır!");
        }
    }
}
