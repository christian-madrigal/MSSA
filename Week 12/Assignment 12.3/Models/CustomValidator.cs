using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;

namespace Assignment_12._3.Models
{
    public class CustomValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return ((string)value).All(Char.IsLetter);
        }
        public override string FormatErrorMessage(string name)
        {
            return base.FormatErrorMessage(name);
        }


    }
}
