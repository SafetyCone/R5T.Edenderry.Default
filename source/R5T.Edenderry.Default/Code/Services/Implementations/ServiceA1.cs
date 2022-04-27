using System;

using R5T.T0064;


namespace R5T.Edenderry.Default
{
    [ServiceImplementationMarker]
    public class ServiceA1 : IServiceA, IServiceImplementation
    {
        public const string ValueA1 = "A1";


        public string GetA()
        {
            return ServiceA1.ValueA1;
        }
    }
}
