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
			theDict.Add(theParticipants.hungary,theFireworksClass.fctCreateMeta("The Swedish Dish", 200, "Hungary"));
			theDict.Add(theParticipants.colombia,theFireworksClass.fctCreateMeta("The Colombian Dish", 182, "Colombia"));
			theDict.Add(theParticipants.brazil,theFireworksClass.fctCreateMeta("The brazil Dish", 182, "Brazil"));
			theDict.Add(theParticipants.congo,theFireworksClass.fctCreateMeta("The Congo Dish", 60, "Congo"));
			theDict.Add(theParticipants.malawi,theFireworksClass.fctCreateMeta("The Malawi Dish", 87, "Malawi"));
			theDict.Add(theParticipants.norway,theFireworksClass.fctCreateMeta("The Norway Dish", 72, "Norway"));
			theDict.Add(theParticipants.sweden,theFireworksClass.fctCreateMeta("The Sweden Dish", 100, "Sweden"));
			
			//Will use to changer the order that the fireworks are shown.
			//We create a new random value
			Random aRndNum = new Random();
			
			//we get a random value	
			aRndNum.Next(1,8);
			
		
				
			//We ouput the data on each participatinf country.
			foreach (theParticipants val in theParticipants.GetValues(typeof(theParticipants))){
				
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
			}
			
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
			
			Console.WriteLine ("==================");
			
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
