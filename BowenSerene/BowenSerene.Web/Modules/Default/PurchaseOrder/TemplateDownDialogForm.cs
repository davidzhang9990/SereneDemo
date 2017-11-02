
using System.ComponentModel;
using BowenSerene.Default.Entities;
using Serenity.Data.Mapping;

namespace BowenSerene.Default.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("Default.TemplateDown")]
    public class TemplateDownDialogForm
    {
        [DisplayName("供应商"), NotNull,LookupEditor(typeof(SuppliersRow), InplaceAdd = true)]
        public Guid SupplierId { get; set; }
    }
}
