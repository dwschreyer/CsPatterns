using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPatterns.Observer
{
    public class PostOffice : IObservable<Message>
    {
        public PostOffice()
        {

        }

        public IList<IObserver<Message>> Observers { get; set; }

        public IDisposable Subscribe(IObserver<Message> observer)
        {
            if(!Observers.Contains(observer))
            {
                Observers.Add(observer);
            }
            return new Unsubscriber(Observers, observer);
        }
    }
}
