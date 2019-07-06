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
            _columns = new List<Column>();
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

        private void UpdateControls()
        {
            int notSettWidth = GetNotSettableColumnWidth();
            int notSettHeight = GetNotSettableRowHeight();




            foreach (var control in Controls)
            {

            }
        }

        private int GetNotSettableColumnWidth()
        {
            int totalWidth = 0;
            int number = 0;
            int widthWithoutPadding = this.Width - (Padding.Left + Padding.Right);
            foreach (var column in _columns)
            {
                if (column.Width == 0)
                    continue;
                totalWidth += column.Width;
                number++;
            }

            if (totalWidth > widthWithoutPadding)
            {
                throw new IndexOutOfRangeException("Total column width more then control size");
            }

            int notSetWidth = _columns.Count > 0 ? (widthWithoutPadding - totalWidth) / (_columns.Count - number) : widthWithoutPadding;
            return notSetWidth;
        }

        private int GetNotSettableRowHeight()
        {
            int totalHeight = 0;
            int number = 0;
            int heightWithoutPadding = this.Height - (Padding.Top + Padding.Bottom);
            foreach (var row in _rows)
            {
                if (row.Height == 0)
                    continue;
                totalHeight += row.Height;
                number++;
            }

            if (totalHeight > heightWithoutPadding)
            {
                throw new IndexOutOfRangeException("Total row height more then control size");
            }

            int notSetHeigh = _rows.Count > 0 ? (heightWithoutPadding - totalHeight) / (_rows.Count - number) : heightWithoutPadding;
            return notSetHeigh;
        }

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


        private readonly List<Column> _columns;
        public List<Column> Columns
        {
            get => _columns;
        }

        private readonly List<Row> _rows;
        public List<Row> Rows
        {
            get => _rows;
        }
    }
}
