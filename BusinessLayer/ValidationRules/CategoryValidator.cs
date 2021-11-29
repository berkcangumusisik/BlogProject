﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Lütfen Kategori Adını Boş Bırakmayınız")
                .MinimumLength(2).WithMessage("Lütfen 2 Karakter'den daha fazla Veri Girişi Yapınız")
                .MaximumLength(50).WithMessage("Lütfen 50 Karakter'den daha az Veri Girişi Yapınız");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Lütfen Kategori Açıklamasını Boş Bırakmayınız");

        }
    }
}
