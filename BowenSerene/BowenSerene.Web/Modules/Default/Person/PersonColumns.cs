﻿
namespace BowenSerene.Default.Columns
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [ColumnsScript("Default.Person")]
    [BasedOnRow(typeof(Entities.PersonRow))]
    public class PersonColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 PersonId { get; set; }
        [EditLink]
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public String BirthPlace { get; set; }
        public Gender? Gender { get; set; }
        public Int32 Height { get; set; }
    }
}