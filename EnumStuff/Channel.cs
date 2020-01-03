using System;

namespace EnumStuff
{
    [Flags]
    public enum Channel
    {
        None = 0b0000,
        Email = 0b0001,
        Text = 0b0010,
        Voice = 0b0100,
        Billboard = 0b1000,
        Radio = 0b0001_0000,
        Television = 0b0010_0000,

        All = int.MaxValue
    }
}
