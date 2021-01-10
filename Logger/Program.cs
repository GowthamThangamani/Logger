using System;

namespace Logger
{
    //The logger is one important assert during development.We are going to create a Logger library which is used to collect log from the various application.From mobile, Web, even from windows application. 
    //We are going to create 4 C# Library for the logger.
		  //  - Log Handler which collect all log.
		  //  - Log Writer, which will write in files, database, or even in API.
		  //  - Log Viewer, to visualize the log, in all different medium.
		  //  - Log Uploader, which uploads the log to the server.
    //First, we are going to write everything in c#, in .NetStarndard.
    //Later we will develop for the dart. 


    //My suggestion is to create as LogHandler, LogWritter, LogViewer as an opensource project.
    //So that 
		  //  - Anyone can edit it, we can decide whether to accept or not.
 		 //   - we will not lose any code. 
 		 //   - We will get a constant reminder from the public about bugs.
 		 //   - We will get the contribution from the community.
 		 //   - We can make this system more stable.


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
