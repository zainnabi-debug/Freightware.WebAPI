﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
  public  class tblPurchaseOrderNotesModels
    {
        public tblPurchaseOrderNotes Note { get; set; }
        public tblPurchaseOrders PurchaseOrder { get; set; }
        public Notifications.Tables.Notification Notification { get; set; }
       

    }
}
