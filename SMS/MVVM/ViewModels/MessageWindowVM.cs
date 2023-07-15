using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.MVVM.ViewModels
{
    public class MessageWindowVM
    {
        public string Message { get; }

        public MessageWindowVM(string message)
        {
            Message = message;
        }
    }
}
