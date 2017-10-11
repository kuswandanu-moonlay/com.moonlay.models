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
        bool _IsDeleted { get; set; }

        /// <summary>
        /// Recording time against deleted entity. In UTC format
        /// </summary>
        /// <returns></returns>
        DateTime _DeletedUtc { get; set; }

        /// <summary>
        /// Recording user against deleted entity. 
        /// </summary>
        /// <returns></returns>
        string _DeletedBy { get; set; }

        /// <summary>
        /// Recording user agent against deleted entity. 
        /// </summary>
        /// <returns></returns>
        string _DeletedAgent { get; set; }
    }

}
