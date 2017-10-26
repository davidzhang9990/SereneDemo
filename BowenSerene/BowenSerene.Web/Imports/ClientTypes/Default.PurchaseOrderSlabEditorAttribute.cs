using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace BowenSerene.Default
{
    public partial class PurchaseOrderSlabEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "BowenSerene.Default.PurchaseOrderSlabEditor";

        public PurchaseOrderSlabEditorAttribute()
            : base(Key)
        {
        }
    }
}

