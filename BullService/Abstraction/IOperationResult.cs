using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BullService.Abstraction
{
    public interface IOperationResult
    {
        public bool IsSuccess { get; set; }
        public bool IsError { get; set; }
        public string Message { get; set; }
    }

    public interface IOperationResult<T> : IOperationResult
    {
        public T Payload { get; set; }
    }
}
