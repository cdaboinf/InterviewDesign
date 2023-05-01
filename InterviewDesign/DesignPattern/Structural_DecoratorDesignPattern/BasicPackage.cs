using System;
namespace InterviewDesign.DesignPattern.DecoratorDesignPattern
{
    public class BasicPackage : PackageDecorator
    {
        public BasicPackage(ICar car)
        : base(car)
        {

        }

        public override int Price()
        {
            return base.Price() + 2000;
        }
    }
}
