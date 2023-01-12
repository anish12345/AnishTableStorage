using Azure.Data.Tables;
using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnishTableStorage
{
    public class Order : ITableEntity
    {
        public string orderId { get; set; }
        public string category { get; set; }

        public int quantity { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }
}
