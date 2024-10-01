using EntityLayer.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(a => a.Country).NotEmpty().WithMessage("Ülke adını boş geçemezsiniz!");
            RuleFor(a => a.City).NotEmpty().WithMessage("Şehir adını boş geçemezsiniz!");
            RuleFor(a => a.District).NotEmpty().WithMessage("İlçe adını boş geçemezsiniz!");
            RuleFor(a => a.Neighbourhood).NotEmpty().WithMessage("Mahalle adını boş geçemezsiniz!");
            RuleFor(a => a.Avenue).NotEmpty().WithMessage("Cadde adını boş geçemezsiniz!");
            RuleFor(a => a.Street).NotEmpty().WithMessage("Sokak adını boş geçemezsiniz!");
            RuleFor(a => a.BuildingNumber).NotEmpty().WithMessage("Bina numarasını boş geçemezsiniz!");
            RuleFor(a => a.Apartment).NotEmpty().WithMessage("Bina adını boş geçemezsiniz!");
            RuleFor(a => a.Floor).NotEmpty().WithMessage("Kat numarasını boş geçemezsiniz!");
            RuleFor(a => a.DoorNumber).NotEmpty().WithMessage("Kapı numarasını boş geçemezsiniz!");
            RuleFor(a => a.PostalCode).NotEmpty().WithMessage("Posta kodunu boş geçemezsiniz!");
            RuleFor(a => a.PhoneNumber).NotEmpty().WithMessage("Telefon numarasını boş geçemezsiniz!");
            RuleFor(a => a.PhoneNumber1).NotEmpty().WithMessage("Diğer telefon numarasını boş geçemezsiniz!");
            RuleFor(a => a.Email).NotEmpty().WithMessage("Email adresini boş geçemezsiniz!");
            RuleFor(a => a.MapInformation).NotEmpty().WithMessage("Harita bilgisini boş geçemezsiniz!");
        }
    }
}
