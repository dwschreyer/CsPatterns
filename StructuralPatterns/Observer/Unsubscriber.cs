using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPatterns.Observer
{
    public class Unsubscriber : IDisposable
    {
        private IObserver<Message> _observer;
        private IList<IObserver<Message>> _observers;
        public Unsubscriber(IList<IObserver<Message>> observers, IObserver<Message> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
