using System;
using System.Collections.Generic;
using System.Collections;

namespace EFCoreAIGS.EF_ERP
{
    public partial class DataSourceConfig
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
        public string? Description { get; set; }
        public BitArray? IsActive { get; set; }
    }
}
