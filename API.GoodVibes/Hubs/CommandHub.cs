using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.GoodVibes.Hubs
{
	public class CommandHub
	{

		// https://docs.microsoft.com/en-us/aspnet/signalr/overview/guide-to-the-api/hubs-api-guide-javascript-client

		//How to create a physical file for the SignalR generated proxy

		//As an alternative to the dynamically generated proxy, you can create a physical file that has the proxy code and reference that file.You might want to do that for control over caching or bundling behavior, or to get IntelliSense when you are coding calls to server methods.
		//To create a proxy file, perform the following steps:
		//Install the Microsoft.AspNet.SignalR.Utils NuGet package.
		//Open a command prompt and browse to the tools folder that contains the SignalR.exe file. The tools folder is at the following location:
		//[your solution folder]\packages\Microsoft.AspNet.SignalR.Utils.2.1.0\tools
		//Enter the following command:
		//signalr ghp /path:[path to the.dll that contains your Hub class]
		//The path to your.dll is typically the bin folder in your project folder.
		//This command creates a file named server.js in the same folder as signalr.exe.
		//Put the server.js file in an appropriate folder in your project, rename it as appropriate for your application, and add a reference to it in place of the "signalr/hubs" reference.


	}
}