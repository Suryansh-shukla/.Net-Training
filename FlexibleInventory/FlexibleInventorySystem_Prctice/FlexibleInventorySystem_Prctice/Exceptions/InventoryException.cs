using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleInventorySystem_Practice.Exceptions
{
    public class InventoryException : Exception
    {
        public string? ErrorCode { get; }
        public InventoryException() : base()
        {

        }
        public InventoryException(string errorMessage) : base(errorMessage) { }
        public InventoryException(string errorMessage, Exception innerException) : base(errorMessage, innerException) { }
        public InventoryException(string errorMessage, string errorCode) : base(errorMessage)
        {
            ErrorCode = errorCode;
        }
        public override string Message
        {
            get
            {
                if (!string.IsNullOrEmpty(ErrorCode))
                {
                    return $"Error Code: {ErrorCode} - {base.Message}";
                }
                return base.Message;
            }

        }
    }
}