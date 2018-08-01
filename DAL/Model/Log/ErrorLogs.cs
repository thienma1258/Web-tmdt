using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model
{
   public class ErrorLogs
    {
        [Key]
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public string TableName { get; set; }
        public string ErrorLog { get; set; } = string.Empty;
        public string ModuleName { get; set; }
        public string FunctionName { get; set; }
    }
}
