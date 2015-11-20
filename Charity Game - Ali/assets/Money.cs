using UnityEngine;
using System.Collections;

public class Money : MonoBehaviour {


	public static int _currentMoney; 



	public static void AddTo(int amount){
        
		_currentMoney += amount;
		}

	public static void pay(int amount){
        if(_currentMoney - amount >= 0 ) { 
		_currentMoney -= amount;       
        }


    }


	private void OnGUI(){
		GUI.Box (new Rect (Screen.width - 150, 60, 150, 20), "Money: " + _currentMoney.ToString ()); 
        
	}

	/*void OnGUI{
		GUI.Box (new Rect (300, 120, 100, 20), _currentMoney.toString()); 
	} */

	public int currentMoney{
		get{
			return _currentMoney;
		}
	}
}
