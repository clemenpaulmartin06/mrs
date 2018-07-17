using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Models
{
    public class ReadingList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Route { get; set; }
        public string AccountId { get; set; }
        public string MeterId { get; set; }
        public string BackgroundColor { get; set; }
    }
}
