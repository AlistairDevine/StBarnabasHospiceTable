using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StBarnabasHospiceTable.Client.Pages.SessionState
{
    public class CounterState
    {
        //Current button countervalue for the entire application.
        private int _buttonCount = 0;
        //StateChanged is an event handler other pages can subscribe to.
        public event EventHandler StateChanged;

        //This will always return the current count.
        public int GetCurrentCount()
        {
            return _buttonCount;
        }
        //This method will be called to update the current count.
        public void UpdateCurrentCount(int paramCount)
        {
            _buttonCount = paramCount;
            StateHasChanged();
        }
        //This will allow us to reset the current count.
        public void ResetCurrentCount()
        {
            _buttonCount = 0;
            StateHasChanged();
        }
        //This will update any scribers that the counter state has changed so they can update themselves and show the current counter value.
        private void StateHasChanged()
        {
            StateChanged.Invoke(this, EventArgs.Empty);
        }
    }
}
