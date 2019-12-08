using System;


namespace R5T.Edenderry.Default
{
    public class ServiceA2 : IServiceA
    {
        public const string ValueA2 = "A2";


        public string GetA()
        {
            return ServiceA2.ValueA2;
        }
    }
}
