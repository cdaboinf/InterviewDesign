﻿using System;
using System.Collections.Generic;

namespace DesignPatterns.DesignPattern.Behavioral_ObserverDesignPattern
{
    internal class Unsubscriber<BaggageInfo> : IDisposable
    {
        private readonly List<IObserver<BaggageInfo>> _observers;
        private readonly IObserver<BaggageInfo> _observer;

        internal Unsubscriber(List<IObserver<BaggageInfo>> observers, IObserver<BaggageInfo> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}