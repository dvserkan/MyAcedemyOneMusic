using FluentValidation;
using OneMusic.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.BusinessLayer.Validators
{
	public class SingerValidator :AbstractValidator<Singer>
	{
        public SingerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Şarkıcı Adı Boş Bırakılamaz!").MaximumLength(50).WithMessage("En Fazla 50 Karakter Yazabilirsiniz !").MinimumLength(4).WithMessage("En Az 4 Karakter Yazmalısınız !");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Url Değeri Boş Bırakılamaz");
        }

    }
}
