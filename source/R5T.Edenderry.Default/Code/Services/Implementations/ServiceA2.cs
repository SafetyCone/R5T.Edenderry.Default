using System;

using R5T.T0064;


namespace R5T.Edenderry.Default
{
    [ServiceImplementationMarker]
    public class ServiceA2 : IServiceA, IServiceImplementation
    {
        public const string ValueA2 = "A2";


        public string GetA()
        {
            return ServiceA2.ValueA2;
        }
    }
}
