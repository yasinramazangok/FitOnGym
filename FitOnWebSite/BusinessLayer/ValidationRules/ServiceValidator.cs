using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ServiceValidator : AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            RuleFor(s => s.Title).NotEmpty().WithMessage("Başlığı boş geçemezsiniz!");
            RuleFor(s => s.Description).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz!");
            RuleFor(s => s.Image).NotEmpty().WithMessage("Görsel yolunu boş geçemezsiniz!");
        }
    }
}
