using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Moonlay.Models
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISoftEntity
    {
        /// <summary>
        /// Flagging deleted entity.
        /// </summary>
        /// <returns>Boolean</returns>
        bool IsDeleted { get; set; }

        /// <summary>
        /// Recording time against deleted entity. In UTC format
        /// </summary>
        /// <returns></returns>
        DateTime DeletedUtc { get; set; }

        /// <summary>
        /// Recording user against deleted entity. 
        /// </summary>
        /// <returns></returns>
        string DeletedBy { get; set; }

        /// <summary>
        /// Recording user agent against deleted entity. 
        /// </summary>
        /// <returns></returns>
        string DeletedAgent { get; set; }
    }

}
