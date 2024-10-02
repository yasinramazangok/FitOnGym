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
            RuleFor(p => p.Limit).NotEmpty().WithMessage("Limit bilgisini boş geçemezsiniz!");
            RuleFor(p => p.Price).NotEmpty().WithMessage("Fiyat bilgisini boş geçemezsiniz!");
            RuleFor(p => p.ClassCategory).NotEmpty().WithMessage("Sınıf kategorisini boş geçemezsiniz!");
            RuleFor(p => p.Description).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz!");
        }
    }
}
