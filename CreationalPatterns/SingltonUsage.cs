using CreationalPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns
{
    public static class SingltonUsage
    {
        public static DateTime GetCreatedAt()
        {
            var result = ApplicationContext.Instance.CreatedAt;
            return result;
        }

        public static DateTime GetModernCreatedAt()
        {
            var result = ModernApplicationContext.Instance.CreatedAt;
            return result;
        }
    }
}
