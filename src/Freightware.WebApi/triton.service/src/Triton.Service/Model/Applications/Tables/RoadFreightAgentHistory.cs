﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.Applications.Tables
{
    [Table("RoadFreightAgentHistory")]
    public class RoadFreightAgentHistory
    {
        [Key]
        public int RoadFreightAgentHistoryID { get; set; }
        public string Comments { get; set; }
        public int RoadFreightAgentID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
