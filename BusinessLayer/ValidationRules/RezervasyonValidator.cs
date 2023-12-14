using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BusinessLayer.ValidationRules
{
    public class RezervasyonValidator : AbstractValidator<Rezervasyon>
    {
        public RezervasyonValidator()
        {
            RuleFor(x => x.Musteri).NotEmpty().WithMessage("Bilgilerinizi boş bırakamazsınız!");
            RuleFor(x => x.GidisTarihi).NotEmpty().WithMessage("Gidiş tarihi kısmı boş geçilemez!..");
            RuleFor(x => x.DonusTarihi).NotEmpty().WithMessage("Dönüş Tarihi alanı boş geçilemez!..");
            RuleFor(x => x.SecilenOtel).NotEmpty().WithMessage("Konaklayacağını oteli seçiniz!..");
            RuleFor(x => x.SecilenOda).NotEmpty().WithMessage("Odayı seçiniz!..");
            
        }
    }
}