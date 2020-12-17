using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Model
{
    public interface IContext
    {
        bool IsSynchronized { get; }
        void Invoke(Action action);
        void BeginInvoke(Action action);
    }
}
