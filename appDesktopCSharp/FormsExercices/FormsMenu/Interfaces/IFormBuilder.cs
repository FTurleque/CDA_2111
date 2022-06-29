using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsMenu.Interfaces
{
    public interface IFormBuilder
    {
        Form CreateInstance(Form parent);
    }
}
