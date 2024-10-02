using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz!");
            RuleFor(c => c.Type).NotEmpty().WithMessage("Kategori türünü boş geçemezsiniz!");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz!");
            RuleFor(c => c.ImageUrl).NotEmpty().WithMessage("Görsel yolunu boş geçemezsiniz!");
            RuleFor(c => c.Description).MinimumLength(100).WithMessage("Açıklama minimum 100 karakter olmalıdır!");
            RuleFor(c => c.Description).MaximumLength(750).WithMessage("Açıklama maksimum 750 karakter olmalıdır!");
        }
    }
}
