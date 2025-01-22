using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongMay_G4
{
    internal class EventManager
    {
        public static event EventHandler<EventArgs> ButtonClicked;

        public static void OnButtonClicked()
        {
            ButtonClicked?.Invoke(null, EventArgs.Empty);
        }
    }
}
