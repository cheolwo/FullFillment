﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 판매Common.DTO;

namespace 판매Common.Actor.Validator
{
    public class Create판매자상품Validator : AbstractValidator<Create판매자상품DTO>
    {
        public Create판매자상품Validator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .Length(1, 100).WithMessage("판매자상품 name must be between 1 and 100 characters.");
        }
    }

    public class Update판매자상품Validator : AbstractValidator<Update판매자상품DTO>
    {
        public Update판매자상품Validator()
        {
            // Other fields can be null, but if they are not null, they should meet the requirements.
            RuleFor(x => x.Name)
                .Length(1, 100).When(x => !string.IsNullOrEmpty(x.Name))
                .WithMessage("판매자상품 name must be between 1 and 100 characters.");
        }
    }

    public class Delete판매자상품Validator : AbstractValidator<Delete판매자상품DTO>
    {
        public Delete판매자상품Validator()
        {
            // Generally, only the Id is required for a delete.
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required.");
        }
    }
}
