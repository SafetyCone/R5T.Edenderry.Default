using System;


namespace R5T.Edenderry.Default
{
    public class ServiceA1 : IServiceA
    {
        public const string ValueA1 = "A1";


        public string GetA()
        {
            return ServiceA1.ValueA1;
        }
    }
}
