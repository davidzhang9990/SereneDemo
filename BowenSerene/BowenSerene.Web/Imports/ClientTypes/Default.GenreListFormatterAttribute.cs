using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace BowenSerene.Default
{
    public partial class GenreListFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "BowenSerene.Default.GenreListFormatter";

        public GenreListFormatterAttribute()
            : base(Key)
        {
        }
    }
}

