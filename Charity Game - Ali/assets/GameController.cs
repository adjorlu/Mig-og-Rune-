using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	
	private void Awake(){
		SetupGame();

	}

	private void SetupGame(){
		Money.AddTo (100); 
		JobsMaster.SetupDefaultJobs();
		CitizenMaster.Init();
		this.GetComponent<Clock>().StartClock();
	}
}
