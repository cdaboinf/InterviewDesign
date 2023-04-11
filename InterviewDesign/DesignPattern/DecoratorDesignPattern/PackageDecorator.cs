using System;
namespace InterviewDesign.DesignPattern.DecoratorDesignPattern
{
    /*
     * Intent Attach additional responsibilities to an object dynamically. 
     * Decorators provide a flexible alternative to subclassing for extending functionality.
        Client-specified embellishment of a core object by recursively wrapping it.
        Wrapping a gift, putting it in a box, and wrapping the box.

        Problem:
        You want to add behavior or state to individual objects at run-time.
        Inheritance is not feasible because it is static and applies to an entire class.
     */
    // Subclassing is a term that refers to
    // inheriting properties for a new object from a base or superclass object. 
    public abstract class PackageDecorator : ICar
    {
        private ICar _car;

        public PackageDecorator(ICar car)
        {
            this._car = car;
        }

        public virtual int Price()
        {
            return _car.Price();
        }
    }
}
