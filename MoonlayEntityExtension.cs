using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Moonlay.Models
{
    public static class MoonlayEntityExtension
    {
        public static void FlagForDelete(this ISoftEntity entity, string deletedBy, string userAgent)
        {
            entity._DeletedBy = deletedBy;
            entity._DeletedUtc = DateTime.UtcNow;
            entity._IsDeleted = true;
            entity._DeletedAgent = userAgent;
        }

        public static void FlagForUpdate(this IAuditEntity entity, string modifiedBy, string userAgent)
        {
            entity._LastModifiedBy = modifiedBy;
            entity._LastModifiedUtc = DateTime.UtcNow;
            entity._LastModifiedAgent = userAgent;
        }

        public static void FlagForCreate(this IAuditEntity entity, string createdBy, string userAgent)
        {
            entity._CreatedBy = createdBy;
            entity._CreatedUtc = DateTime.UtcNow;
            entity._CreatedAgent = userAgent;
        }
    }
}
