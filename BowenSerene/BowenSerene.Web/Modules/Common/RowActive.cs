
using System;

namespace BowenSerene.Default
{
    using Serenity.ComponentModel;
    using System.ComponentModel;

    [EnumKey("Default.RowActive")]
    public enum RowActive
    {
        [Description("锁定")]
        Locked = 0,
        [Description("正常")]
        Active = 1
    }
}