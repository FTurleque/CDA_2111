using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsMenu
{
    internal class Scrolling
    {
        private HScrollBar scrollBar;
        private NumericUpDown numUpDown;
        private Label label;
        public Color NewColor { get; set; }

        public Scrolling(HScrollBar _scrollBar, NumericUpDown _numUpDown, Label _label, Color _color)
        {
            scrollBar = _scrollBar;
            numUpDown = _numUpDown;
            label = _label;
            NewColor = _color;
            scrollBar.Tag = this;
            numUpDown.Tag = this;
        }

        public void ChangeValue(int _value)
        {
            scrollBar.Value = _value;
            numUpDown.Value = _value;
            label.BackColor = Color.FromArgb(_value, NewColor);
        }

        public void ChangeValue(decimal _value)
        {
            ChangeValue((int)_value);
        }
    }
}
