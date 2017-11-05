using System;
using System.Collections.Generic;
using BowenSerene.Default.Entities;
using Serenity.Services;

namespace BowenSerene.Default
{
    public class InspectionDeleteRequest : DeleteRequest
    {
        public List<InspectionDetailRow> InspectionDetails;
    }
}