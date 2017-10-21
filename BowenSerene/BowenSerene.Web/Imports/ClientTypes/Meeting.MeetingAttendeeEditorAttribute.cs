using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace BowenSerene.Meeting
{
    public partial class MeetingAttendeeEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "BowenSerene.Meeting.MeetingAttendeeEditor";

        public MeetingAttendeeEditorAttribute()
            : base(Key)
        {
        }
    }
}

