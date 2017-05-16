using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Exception
{

    /// <summary>
    /// 
    /// ConferenceInProgressException class
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    class ConferenceInProgressException : BaseException
    {
        public ConferenceInProgressException(string message) : base(message)
        {
            
        }
    }
}
