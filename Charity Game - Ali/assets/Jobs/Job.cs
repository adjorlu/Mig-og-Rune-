using UnityEngine;
using System.Collections;

public class Job : MonoBehaviour {

	public int _salary;
	//public int _effectOnHappiness;
	

    private bool _MiningJob = false; 


    

    public static void miningJob(Citizen citizen)
    {
        citizen.job = "God mining";
        citizen.income = 5; 
    }

    public static void CoffeFarm(Citizen citizen)
    {
        citizen.job = "Coffe farming";
        citizen.income = 5; 
    }

    public static void getWater(Citizen citizen)
    {
        WaterStorage.AddTo(50); 
    }

    public static void QuitJob(Citizen citizen)
    {
        citizen.job = "Unemployed";
        citizen.income = 0; 
    }


	/*private void mineWork(_selectedCitizen) {


		_selectedCitizen.job = "Mining"; 

	}
 */ 



}
