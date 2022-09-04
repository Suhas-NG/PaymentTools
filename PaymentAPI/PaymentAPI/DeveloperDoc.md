Dependies-> 
	 Frameworks 
		->Microsoft AspNetcore.app
			......
		->

Launch Settings 
"profiles": {
    "PaymentAPI": {  
      "commandName": "Project", //castrol web server project run iis 
      "dotnetRunMessages": true,  // 
      "launchBrowser": false,
      "applicationUrl": "https://localhost:7249;http://localhost:5249",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "launchUrl": "swagger",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }

-> Go to properties and the select the launch url in debug 

tools 

   ->https://docs.microsoft.com/en-us/dotnet/core/tools/
   Routing : https://docs.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-6.0