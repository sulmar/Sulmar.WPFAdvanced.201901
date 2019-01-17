using Sulmar.WPF.Advanced.IServices;
using Sulmar.WPF.Advanced.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sulmar.WPF.Advanced.FakeServices
{
    public class FakeOptionsGroupsService : IOptionsGroupsService
    {
        private readonly IEnumerable<OptionsGroup> optionsGroups;

        public FakeOptionsGroupsService(OptionsGroupFaker optionsGroupFaker)
        {
            this.optionsGroups = optionsGroupFaker.Generate(10);
        }

        public IEnumerable<OptionsGroup> Get() => optionsGroups;

        public OptionsGroup Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
