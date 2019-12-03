using System;

namespace TeduShop.Model.Models
{
    public partial class Error
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public string StackTrace { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}