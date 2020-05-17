using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class SnakePart
    {
        public System.Windows.UIElement UiElement { get; set; }

        public System.Windows.Point Position { get; set; }

        public bool IsHead { get; set; }
    }
}
