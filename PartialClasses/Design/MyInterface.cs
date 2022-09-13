using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses.Design
{
    public interface MyInterface
    {
        string SomeString { get; set; }
        event EventHandler SomeEvent;
        void SomeMethod();
    }
}
