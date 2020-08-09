using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicalog.WebApi.Util
{
    public static class ErrorHandling
    {
        public static string ReturnErrorMessage(Exception exception)
        {
            if (exception.InnerException == null)
                return exception.Message;
            else
                return ReturnErrorMessage(exception.InnerException);
        }
    }
}
