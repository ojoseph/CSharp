using System;
//We call the system Collection generic in order to use the arrayLists
using System.Collections.Generic;

//We call for the collections in order to use Hastable
using System.Collections;

namespace SimpleProgram1
{
	class MainClass
	{	
		//We declare the participants  of our  Hanabi Taikai
		enum theParticipants{
			hungary,
			colombia,
			sweden,
			malawi,
			norway,
			brazil,
			congo
		}
		
		public static void Main (string[] args)
		{
	
			//We create a dictionnary that will hold all the data where the key is a enum.
			Dictionary<theParticipants, string> theDict = new Dictionary<theParticipants, string>();
			
			//Will  hold the totalduration of the Taikai	
			float theTotalDuration = 0;	
			
			//We create and instace of the class fireworks for each particapating country
			fireworks theFireworksClass = new fireworks();
			theDict.Add(theParticipants.hungary,theFireworksClass.fctCreateMeta("The Hungarian Dish", 200, "Hungary"));
			theDict.Add(theParticipants.colombia,theFireworksClass.fctCreateMeta("The Colombian Dish", 182, "Colombia"));
			theDict.Add(theParticipants.brazil,theFireworksClass.fctCreateMeta("The Brazilian Dish", 182, "Brazil"));
			theDict.Add(theParticipants.congo,theFireworksClass.fctCreateMeta("The Congo Dish", 60, "Congo"));
			theDict.Add(theParticipants.malawi,theFireworksClass.fctCreateMeta("The Malawian Dish", 87, "Malawi"));
			theDict.Add(theParticipants.norway,theFireworksClass.fctCreateMeta("The Norway Dish", 72, "Norway"));
			theDict.Add(theParticipants.sweden,theFireworksClass.fctCreateMeta("The Swedish Dish", 100, "Sweden"));
			
			
			
			//Console.WriteLine(theDict[thePartOrder]);
			//theDict[thePartOrder];
			
			//string[] theOrder;
			List<theParticipants> theListOrder = new List<theParticipants>();
			
			//We add all the participants in a list
			foreach(theParticipants theValue in theParticipants.GetValues(typeof(theParticipants))){
				theListOrder.Add(theValue);
				//Console.WriteLine("Contains" + theListOrder);
			}
			
			
			//Will use to changer the order that the fireworks are shown.
			//We create a new random value
			Random aRndNum = new Random();
			
			//We reorder everything int a new List
			List<theParticipants> theFinalListOrder = new List<theParticipants>();
			
			
			//We randomly take the values from the first table and pass them to the other table.
			// In the process we delete the previous data in order to avoid the items to be selected twice.
			while(theListOrder.Count > 0){
				int rndSlct = aRndNum.Next (0, theListOrder.Count);
				//Console.WriteLine("!!!"+theListOrder.Count);
				theFinalListOrder.Add (theListOrder[rndSlct]);
				theListOrder.RemoveAt (rndSlct);
			}
			
			//Output the data all over to see it works
			for(int ret = 0; ret < theFinalListOrder.Count; ret++){
				
				//Console.WriteLine(theFinalListOrder[ret]);
				
			}
			
			
			Console.WriteLine ("+++++++++++++++++++++++++++++++++++++++");
			Console.WriteLine ("Pull out the list in  Random Orders");
			Console.WriteLine ("+++++++++++++++++++++++++++++++++++++++");
				
			
			foreach(theParticipants theTakenValue in theFinalListOrder){
				
				//Output the enums in random orders.
				Console.WriteLine("***"+theTakenValue);
				
				//We get the data from the dicitonnary and split it into an array 
				string[] array = theDict[theTakenValue].Split(',');
				Console.WriteLine("The Name of the fireworks: " + array[0]);
				
				//We pick up the time value and convert it into a float value
				float tempDuration = Convert.ToInt32(array[1]);
				
				//We call the class that will take care of calculations
				calculate getMyTime = new calculate();
				
				//We create a temporary variable and call the class.ftc that will calculate time.
				double currentDuration = getMyTime.giveMeHours(tempDuration);
				
				Console.WriteLine("The duration: " + currentDuration + getMyTime.moreThanOneHour(currentDuration));
				
				//We update the total duration of the event.
				theTotalDuration +=  tempDuration;
					
				//We jsut output the Country
				Console.WriteLine("The Country: " + array[2]);
				
				//We skip a line in order to keep it clear
				Console.WriteLine ("");
			}
			
			Console.WriteLine ("+++++++++++++++++++++++++++++++++++++++");
			
			
			
			/*//for(int u = 0; u < theListOrder.Count; u++){
			for(int u = theListOrder.Count-1; u >= 0; u--){
				
				Console.WriteLine("sega" + u +theListOrder.Count);
				theListOrder.RemoveAt(u);
				//Dont know why but it stops lowering after 4....
				
				
				//we get a random value	
			/*	int thePartOrder = aRndNum.Next(0,theListOrder.Count);
				Console.WriteLine(thePartOrder + "-------------------" + theListOrder[thePartOrder]);
				
				theFinalListOrder.Add(theListOrder[thePartOrder]);
				theListOrder.RemoveAt(thePartOrder);
				Console.WriteLine( "AAA" + theFinalListOrder);*/
				
			//}
			
		
			
			
			
			
			
			
			
			
				
			//We ouput the data on each participatinf country.
			/*foreach (theParticipants val in theParticipants.GetValues(typeof(theParticipants))){
				
				//We get the data from the dicitonnary and split it into an array 
				string[] array = theDict[val].Split(',');
				Console.WriteLine("The Name of the fireworks: " + array[0]);
				
				//We pick up the time value and convert it into a float value
				float tempDuration = Convert.ToInt32(array[1]);
				
				//We call the class that will take care of calculations
				calculate getMyTime = new calculate();
				
				//We create a temporary variable and call the class.ftc that will calculate time.
				double currentDuration = getMyTime.giveMeHours(tempDuration);
				
				Console.WriteLine("The duration: " + currentDuration + getMyTime.moreThanOneHour(currentDuration));
				
				//We update the total duration of the event.
				theTotalDuration +=  tempDuration;
					
				//We jsut output the Country
				Console.WriteLine("The Country: " + array[2]);
				
				//We skip a line in order to keep it clear
				Console.WriteLine ("");
			}*/
			
			Console.WriteLine ("==================");
					
			//We set a new firework's data.
			fireworks getFireWorksInfo = new fireworks();
			getFireWorksInfo.nameOfTaikai = "The Maple Cake";
			getFireWorksInfo.yearOfTaikai = 2013;
			getFireWorksInfo.theme = "Flowers and Chocolate";
			getFireWorksInfo.country = "England";
			
			//We display the previously set Data
			Console.WriteLine("Overall Infos Concerning " + getFireWorksInfo.yearOfTaikai +"'s Taikai");
			Console.WriteLine("Name: " + getFireWorksInfo.nameOfTaikai);
			Console.WriteLine("Theme: " + getFireWorksInfo.theme);
			Console.WriteLine("Place: " + getFireWorksInfo.country);
			
			//We distplay the number of participants for this year
			Console.WriteLine("Partcipants: " + theDict.Count);
			
			//We need to do some calculation so we call the class appropriate for that
			calculate convertHours = new calculate();
			Console.WriteLine("The total duration: " +   convertHours.giveMeHours(theTotalDuration) + convertHours.moreThanOneHour(theTotalDuration));
			
			DateTime theCurrentDate = DateTime.Now;
			//We set the new time value, convert added hours from double -> int32 (a normal int)
			TimeSpan theAddedTime = new TimeSpan(0,Convert.ToInt32(convertHours.giveMeHours(theTotalDuration)),0,0);
			DateTime thePrevisionEnd = theCurrentDate.Add(theAddedTime);
			
			//We let the user know when we think the event will end.
			Console.WriteLine("Will end on: "+ thePrevisionEnd);
			
			Console.WriteLine ("==================");
			Console.WriteLine ("========  DATE MANIPULATION  ==========");	
			
			//We make and instance of the  actual time.	
			DateTime theDate = DateTime.Now;	
			//We set up the time we want to add	
			TimeSpan theTimeSpan = new TimeSpan(0,1,1,0);
			//We add this in a new time Value	
			DateTime theNewTimeValue = theDate.Add(theTimeSpan);
			Console.WriteLine("The time in an hour: " + theNewTimeValue.Hour + ":" + theNewTimeValue.Minute);
				
			Console.WriteLine ("");
				
			Console.WriteLine("Time Now: " + DateTime.Now.TimeOfDay);	
			//Console.WriteLine("Time in an Hour" + DateTime.Now.TimeOfDay + 1);	
				
			/*while(DateTime.Now.Minute < 57){
					Console.WriteLine("2222");
			}*/
			
				
				
				
				
			
		}
			
			
			
	}
	
	//The class for this year's firework.
	class fireworks{
		public int yearOfTaikai;
		public string nameOfTaikai;
		public string theme;
		public string country;
		
		public string fctCreateMeta(string theName, int theDuration, string theCountry){
			
			//We put everything together so that we decompress it later with a split.
			string metaData = theName + "," + theDuration + "," + theCountry;
			
			//We return the metaData.
			return metaData;
		}	
	}
	
	
	//Class that Will  take care of all the calculations for us.
	class calculate{
		
		public double giveMeHours(float theTimeValue){
		   double convertedTime = (Math.Round(theTimeValue/60));
			
			//We Return the value
			return convertedTime;
		}
		
		
		//This function checks if we need to write Hour or hours.
		public string moreThanOneHour(double nbHours){
			if(nbHours > 1){
				
				return "hours";
			}else{
				return "hour";
			}
			
		}	
	}
	
	
	
	
	
}
