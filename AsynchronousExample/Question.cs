using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronousExample
{
    class Question
    {
        public string Questions { get; set; }
        public List<CheckBox> optionCheckbox { get; set; }
    }
}
