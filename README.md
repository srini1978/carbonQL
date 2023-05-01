# carbonQL

## Usage of the solution

1. Download the solution from GitHub and open in Visual Studio
2. Build and run the console project
3. Running the exe on command prompt, we can give the model name, telemetry parameters and emissions data will be returned. 

E.g
* carbonQL –modelName Etsy –vCPUHours 100 –ssdTBHours 200 –hddTBHours 300 *
* Output will be in Watthours *
4. During setup itself someone can mention if the output needs to be verbose or not and correspondingly the output could have details of the carbon emission calculations

## Structure of the solution

**CarbonQLBackend**: Contains the Model and Controller class. Model classes are the in memory entities for object like Telemetry, Models etc. 
Model project Will contain classes for all the models- Etsy.cs, Boazvita.cs,CCF.cs Model project Will also contain the entity classes for the Telemetry objects.
Calculations are encapsulated in the Controller classes. Each Model will have their own calculation controller classes.

**CarbonQLConsole**: Contains the front end of the solution. This is a console application for now. This is where we pass the parameters as specified above in the example
