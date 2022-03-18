using System;

namespace Coding.Exercise
{
    public class SingletonTester
    {
        public static bool IsSingleton(Func<object> func)
        {
            var instance1 = func();
            var instance2 = func();
            return instance1.Equals(instance2);
        }
    }
}
