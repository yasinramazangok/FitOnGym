using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(a => a.TagLine).NotEmpty().WithMessage("Üst bilgiyi boş geçemezsiniz!");
            RuleFor(a => a.Description).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz!");
            RuleFor(a => a.TagLine).MinimumLength(5).WithMessage("Üst bilgi minimum 3 karakter olmalıdır!");
            RuleFor(a => a.TagLine).MaximumLength(50).WithMessage("Üst bilgi maksimum 50 karakter olmalıdır!");
            RuleFor(a => a.Description).MinimumLength(100).WithMessage("Açıklama minimum 100 karakter olmalıdır!");
            RuleFor(a => a.Description).MaximumLength(750).WithMessage("Açıklama maksimum 750 karakter olmalıdır!");


        }
    }
}
