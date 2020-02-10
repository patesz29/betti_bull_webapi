using BullService.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BullService.Helpers
{
    public class OperationResult : IOperationResult
    {
        public bool IsSuccess { get; set; }
        public bool IsError { get; set; }
        public string Message { get; set; }

        public OperationResult(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
        public OperationResult(bool isError, string message)
        {
            IsError = isError;
            Message = message;
        }
    }
    public class OperationResult<T> : OperationResult, IOperationResult<T> where T: class
    {
        public T Payload { get; set; }

        public OperationResult(bool isSuccess, T payload) : base(isSuccess)
        {
            IsSuccess = isSuccess;
            Payload = payload;
        }
    }
}
