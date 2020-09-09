using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Model
{
    public class CustomEditModel
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
