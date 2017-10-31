using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace BowenSerene.Default
{
    public partial class PurchaseOrderStoneEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "BowenSerene.Default.PurchaseOrderStoneEditor";

        public PurchaseOrderStoneEditorAttribute()
            : base(Key)
        {
        }
    }
}

