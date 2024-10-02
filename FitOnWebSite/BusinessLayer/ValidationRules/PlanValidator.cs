using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PlanValidator : AbstractValidator<Plan>
    {
        public PlanValidator()
        {
            RuleFor(p => p.Limit).NotEmpty().WithMessage("Üst bilgiyi boş geçemezsiniz!");
            RuleFor(p => p.Price).NotEmpty().WithMessage("Üst bilgiyi boş geçemezsiniz!");
            RuleFor(p => p.ClassCategory).NotEmpty().WithMessage("Üst bilgiyi boş geçemezsiniz!");
            RuleFor(p => p.Description).NotEmpty().WithMessage("Üst bilgiyi boş geçemezsiniz!");

            RuleFor(a => a.Description).MinimumLength(100).WithMessage("Açıklama minimum 100 karakter olmalıdır!");
            RuleFor(a => a.Description).MaximumLength(750).WithMessage("Açıklama maksimum 750 karakter olmalıdır!");
        }
    }
}
