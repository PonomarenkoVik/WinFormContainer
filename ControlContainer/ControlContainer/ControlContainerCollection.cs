using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace ControlContainer
{
    public class ControlContainerCollection : ControlCollection
    {
        public ControlContainerCollection(ControlContainer ctrl) : base(ctrl)
        {

        }

        
        public virtual ControlContainer this[int index] { get; }
        
        public virtual ControlContainer this[string key] { get; }


    }
}
