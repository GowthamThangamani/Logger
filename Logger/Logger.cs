using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class Logger
    {
        // LogLevel
        // filter logLevel.
        // BaseName
        // type of Message
        //      - Normal Message
        //      - Error Message
        //      - Exception Message
        // Received those log.

        public enum eLogLevel
        {
            verbose,
            debug,
            info,
            warning,
            error,
        }

        string message;
        string error_message;
        string stack_trace;
        private readonly string baseName;

        public Logger(string BaseName = "")
        {
            baseName = BaseName;
        }

        public void V(string message,
                      string error_message = null,
                      string stack_trace = null)
        {

        }

        public void D(string message,
                     string error_message = null,
                     string stack_trace = null)
        {

        }

    }

    class LogHandler
    {

    }
}
