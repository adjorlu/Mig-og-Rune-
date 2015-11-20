using UnityEngine;
using System.Collections;

public class CitizenCreator : MonoBehaviour {

	private static GameObject _citizenPrefab;

	public static GameObject CreateCitizen(bool isNewBorn){
		GameObject citizenObject = Instantiate(CitizenPrefab(), Vector3.zero, Quaternion.identity) as GameObject;
		Citizen citizen = citizenObject.GetComponent<Citizen>();

        bool isMale = Random.value > 0.5f; 
		//bool isMale = Random.Range(0,2) == 0;
		citizen.name = NameProvider.GetRandomName(isMale);
        citizen.job = "Unemployed";
        citizen.isMale = isMale; 
		if(isNewBorn){
			citizen.age = 0;
		}
		else{
            citizen.age = Random.Range(18, 22);
		}

		return citizenObject;
	}

	private static GameObject CitizenPrefab(){
		if(_citizenPrefab==null){
			_citizenPrefab = Resources.Load("Prefabs/Citizen") as GameObject;
		}
		return _citizenPrefab;
	}
}
