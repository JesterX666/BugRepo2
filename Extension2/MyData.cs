using Microsoft.VisualStudio.Extensibility.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Data;
using static System.Net.Mime.MediaTypeNames;

namespace Extension2
{
    [DataContract]
    internal class MyToolWindowData
    {
        [DataMember]
        public ObservableList<ReportDataSource> GridData { get; set; } = new ObservableList<ReportDataSource>();

        public MyToolWindowData()
        {
            GridData.Add(new ReportDataSource { ItemId = 1, ItemName = "Item1" });
            GridData.Add(new ReportDataSource { ItemId = 2, ItemName = "Item2" });
            GridData.Add(new ReportDataSource { ItemId = 3, ItemName = "Item3" });
        }

        [DataContract]
        public class ReportDataSource
        {
            [DataMember]
            public int ItemId { get; set; }

            [DataMember]
            public string ItemName { get; set; } = String.Empty;
        }
    }
}
