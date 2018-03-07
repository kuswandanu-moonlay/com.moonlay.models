using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Moonlay.Models
{
    public static class MoonlayEntityExtension
    {
        public static void FlagForDelete(this ISoftEntity entity, string deletedBy, string userAgent, bool isDeleted = true)
        {
            entity.IsDeleted = isDeleted;
            entity.DeletedBy = deletedBy;
            entity.DeletedUtc = DateTime.UtcNow;
            entity.DeletedAgent = userAgent;
        }

        public static void FlagForUpdate(this IAuditEntity entity, string modifiedBy, string userAgent)
        {
            entity.LastModifiedBy = modifiedBy;
            entity.LastModifiedUtc = DateTime.UtcNow;
            entity.LastModifiedAgent = userAgent;
            if (entity is ISoftEntity)
                (entity as ISoftEntity).FlagForDelete(modifiedBy, userAgent, false);
        }

        public static void FlagForCreate(this IAuditEntity entity, string createdBy, string userAgent)
        {
            entity.CreatedBy = createdBy;
            entity.CreatedUtc = DateTime.UtcNow;
            entity.CreatedAgent = userAgent;
            entity.FlagForUpdate(createdBy, userAgent);
        }
    }
}
