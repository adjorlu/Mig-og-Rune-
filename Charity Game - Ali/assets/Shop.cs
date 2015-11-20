using UnityEngine;
using System.Collections;

public class Shop : MonoBehaviour {

	private bool _showMenu = false; 



	// Use this for initialization
	private void OnGUI(){
		if(_showMenu){
			if(GUI.Button(new Rect(Screen.width - 100, 100, 100, 100), "Shop")){
				_showMenu = false;
				//_selectedCitizen = null;
			}
			showFood();

		}
		else{
			if(GUI.Button(new Rect(Screen.width - 100, 100,100,100), "Shop")){
				_showMenu = true;
			}
		}
	}


	private void showFood() {
		if (GUI.Button (new Rect (Screen.width - 200, 100, 100, 20), "Mad" )) {
            if( FoodStorage._currentStock < FoodStorage._capacity) { 
            FoodStorage.AddTo(50); 
			Money.pay(20);
            }
        }
	}


}
