using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Singleton
{
    public sealed class ApplicationContext
    {
        private static volatile ApplicationContext _instance;
        private static object _syncRoot = new Object();

        private ApplicationContext() { }

        public static ApplicationContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new ApplicationContext();
                            _instance.CreatedAt = DateTime.UtcNow;
                        }
                    }
                }

                return _instance;
            }
        }

        public DateTime CreatedAt { get; set; }
    }
}
