using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(t => t.Name).NotEmpty().WithMessage("İsmi boş geçemezsiniz!");
            RuleFor(t => t.Title).NotEmpty().WithMessage("Başlığı boş geçemezsiniz!");
            RuleFor(t => t.ImageUrl).NotEmpty().WithMessage("Görsel yolunu boş geçemezsiniz!");
            RuleFor(t => t.FacebookUrl).NotEmpty().WithMessage("Facebook url'i boş geçemezsiniz!");
            RuleFor(t => t.XUrl).NotEmpty().WithMessage("X url'i boş geçemezsiniz!");
            RuleFor(t => t.YoutubeUrl).NotEmpty().WithMessage("YouTube url'i boş geçemezsiniz!");
            RuleFor(t => t.InstagramUrl).NotEmpty().WithMessage("Instagram url'i boş geçemezsiniz!");
            RuleFor(t => t.Email).NotEmpty().WithMessage("Email bilgisini boş geçemezsiniz!");
        }
    }
}
