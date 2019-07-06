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
            _controlGUID = Guid.NewGuid().ToString();
        }


        #region Alightment
        private HorizontalAlign _horizontalAlign;
        public HorizontalAlign HorizontalAlign
        {
            get
            {
                return _horizontalAlign;
            }
            set
            {
                _horizontalAlign = value;
            }
        }

        private VerticalAlign _verticalAlign;
        public VerticalAlign VerticalAlign
        {
            get
            {
                return _verticalAlign;
            }
            set
            {
                _verticalAlign = value;
            }
        }
        #endregion


        private int _columnSpan;
        public int ColumnSpan
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
        public int RowSpan
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

        private readonly string _controlGUID;
        public string ControlGUID
        {
            get => _controlGUID;
        }
    }
}
