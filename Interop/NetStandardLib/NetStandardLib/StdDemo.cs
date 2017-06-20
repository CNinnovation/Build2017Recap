using System;
using FullNetLib;

namespace NetStandardLib
{
    public class StdDemo
    {
        private FullNetDemo demo = new FullNetDemo();

        public string Demo()
        {
            return demo.Sample() + " from .NET Standard";
        }
    }
}
