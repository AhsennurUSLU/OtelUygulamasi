using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BusinessLayer.ValidationRules
{
    public class MusteriValidator : AbstractValidator<Musteri>
    {
        public MusteriValidator() 
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("İsim kısmı boş geçilemez!..");
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Soyisim kısmı boş geçilemez!..");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("e-Mail alanı boş geçilemez!..");
            RuleFor(x => x.TelefonNo).NotEmpty().WithMessage("Lütfen telefon numaranızı giriniz!..");
            RuleFor(x => x.Cinsiyet).NotEmpty().WithMessage("Bu alan boş geçilemez!..!");
            RuleFor(x => x.Parola).NotEmpty().WithMessage("Parola alanı boş geçilemez!..");
            RuleFor(x => x.Parola).MinimumLength(50).WithMessage("Şifreniz en az 8 karakterden oluşmalıdır...");        }
    }
}