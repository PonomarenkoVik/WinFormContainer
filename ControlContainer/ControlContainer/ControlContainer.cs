using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ControlContainer
{
    public class ControlContainer : Control
    {
        private int? _column;
       

        public ControlContainer()
        {
      
        }


        private int _columnSpan;
        public virtual int ColumnSpan
        {
            get
            {                
                return _columnSpan;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                _columnSpan = value;
            }
        }


        private int _rowSpan;
        public virtual int RowSpan
        {
            get
            {
                return _rowSpan;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                _rowSpan = value;
            }
        }


        public int? ColumnCount
        {
                get => _column;
                set
                {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                _column = value;
                }
        }

        public int? RowCount
        {
            get => _column;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                _column = value;
            }
        }
    }
}
