
namespace BowenSerene.Default.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("Default.ProductImport")]
    public class ProductImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}
