using System;
using System.Collections.Generic;
using System.Text;

namespace ScrollingMessage
{
    //Define event argument you want to send while raising event.
    public class MyEventArgs : EventArgs
    {
        public int Value { get; set; }

        public MyEventArgs(int value)
        {
            Value = value;
        }
    }

    public class Pub
    {
        public event EventHandler<MyEventArgs> OnChange = delegate { };

        public void Raise()
        {
            OnChange(this, new MyEventArgs(33));
        }

    }
}
