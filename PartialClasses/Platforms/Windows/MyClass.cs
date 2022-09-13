using PartialClasses.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses.Core
{
    public partial class MyClass : MyInterface
    {
        public string SomeString {get;set;}
        public void SomeMethod() { }
    }
}
