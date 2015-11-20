using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CitizenManagementGUI : MonoBehaviour {

	private bool _showMenu = false;
    private bool _showJobInfo = false; 
	private Citizen _selectedCitizen;
	private string _selectedCitizenName; 


	private void OnGUI(){
		if(_showMenu){
			if(GUI.Button(new Rect(0,100,100,100), "Management")){
				_showMenu = false;
				_selectedCitizen = null;
			}
			ShowCitizens();
			if(_selectedCitizen!=null){
				ShowCitizenInfo(_selectedCitizen);
               
                 if(GUI.Button  (new Rect(Screen.width / 2, 100, 100, 20), "Manage work"))
                {
                    _showJobInfo = true; 
                }
                if (_showJobInfo == true)
                {
                    showJobInfo(_selectedCitizen);                    
                }
            }
		}    
        else
        {
			if(GUI.Button(new Rect(0,100,100,100), "Management")){
				_showMenu = true;
			}
		}
	}

	private void ShowCitizens(){
		List<Citizen> citizens = CitizenMaster.GetCitizens();
		int i=0;
		foreach(Citizen citizen in citizens){
			if(GUI.Button(new Rect(100,100+(i*20),100,20), citizen.name)){
				_selectedCitizen = citizen;
				_selectedCitizenName = citizen.name; 
		
			}
			i++;
		}
	}

	private void ShowCitizenInfo(Citizen citizen){

		GUI.Box(new Rect(Screen.width/2 - 200 ,100, 200,20), "Name: " + citizen.name.ToString());
		GUI.Box(new Rect(Screen.width/2 - 200, 120, 200,20), "Age: " + citizen.age.ToString());
		GUI.Box(new Rect(Screen.width/2 - 200, 140,200,20), "hunger: " + citizen.hunger.ToString());
        GUI.Box(new Rect(Screen.width / 2 - 200, 160, 200, 20), "Current Job: " + citizen.job.ToString());
        GUI.Box(new Rect(Screen.width / 2 - 200, 180, 200, 20), "Income: " + citizen.income.ToString());
    }

    private void showJobInfo(Citizen citizenJob)
    {
       if (GUI.Button(new Rect(Screen.width / 2 , 120, 200, 20), "Gold mine"))
        {
            Job.miningJob(citizenJob);
        }
       else if(GUI.Button(new Rect(Screen.width / 2 , 140, 200, 20), "Coffe farm"))
        {
            Job.CoffeFarm(citizenJob);
        }       

       else if (GUI.Button(new Rect(Screen.width / 2, 160, 200, 20), "Get water"))
        {
            Job.QuitJob(citizenJob);
            Job.getWater(citizenJob); 
        }
    }
}
