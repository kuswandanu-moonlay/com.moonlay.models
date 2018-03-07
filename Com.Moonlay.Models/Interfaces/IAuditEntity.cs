using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Moonlay.Models
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAuditEntity
    {
        /// <summary>
        /// Recording time against created entity. In UTC format
        /// </summary>
        /// <returns></returns>
        DateTime CreatedUtc { get; set; }

        /// <summary>
        /// Recording user against created entity.
        /// </summary>
        /// <returns></returns>
        string CreatedBy { get; set; }

        /// <summary>
        /// Recording user agent against created entity.
        /// </summary>
        /// <returns></returns>
        string CreatedAgent { get; set; }

        /// <summary>
        /// Recording time against modified entity. In UTC format
        /// </summary>
        /// <returns></returns>
        DateTime LastModifiedUtc { get; set; }

        /// <summary>
        /// Recording user against modified entity.
        /// </summary>
        /// <returns></returns>
        string LastModifiedBy { get; set; }

        /// <summary>
        /// Recording user agent against modified entity.
        /// </summary>
        /// <returns></returns>
        string LastModifiedAgent { get; set; }
    }

}
