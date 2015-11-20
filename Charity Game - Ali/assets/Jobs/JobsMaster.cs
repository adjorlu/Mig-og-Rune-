using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JobsMaster : MonoBehaviour {

	private static List<GameObject> _jobsInTheVillage = new List<GameObject>();
	private static List<GameObject> _jobsOutsideTheVillage = new List<GameObject>();

	public static void SetupDefaultJobs(){
		_jobsOutsideTheVillage.Add(Resources.Load("Prefabs/Jobs/Mining") as GameObject);
	}
}
