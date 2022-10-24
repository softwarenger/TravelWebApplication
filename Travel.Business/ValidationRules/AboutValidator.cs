using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Entity.Concrete;

namespace Travel.Business.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama ksımı boş geçilemez");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Lütfen En az 20 karakter giriniz");
            RuleFor(x => x.Description).MaximumLength(1000).WithMessage("Açıklama en fazla 1000 karakter içermek zorundadır");

        }
    }
}
