using Bogus;
using Sulmar.WPF.Advanced.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sulmar.WPF.Advanced.FakeServices
{
    public class OptionsGroupFaker : Faker<OptionsGroup>
    {
        public OptionsGroupFaker(OptionFaker optionFaker)
        {
            StrictMode(true);
            RuleFor(p => p.Name, f => f.Lorem.Word());
            RuleFor(p => p.Options, optionFaker.Generate(5));
        }
    }

    public class OptionFaker : Faker<Option>
    {
        public OptionFaker()
        {
            StrictMode(true);
            RuleFor(p => p.Name, f => f.Lorem.Word());
            RuleFor(p => p.Type, f => f.PickRandom<OptionType>());
            Ignore(p => p.Value);
        }
    }
}
