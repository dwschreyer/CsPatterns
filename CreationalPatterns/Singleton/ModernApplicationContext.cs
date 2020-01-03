using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Singleton
{
    public sealed class ModernApplicationContext
    {
        private static readonly Lazy<ModernApplicationContext> lazy =
            new Lazy<ModernApplicationContext>(() => new ModernApplicationContext(DateTime.UtcNow));

        private ModernApplicationContext(DateTime createdAt)
        {
            CreatedAt = createdAt;
        }

        public static ModernApplicationContext Instance { 
            get 
            {
                return lazy.Value; 
            } 
        }

        public DateTime CreatedAt { get; set; }
    }
}
