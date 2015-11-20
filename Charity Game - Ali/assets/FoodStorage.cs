using UnityEngine;
using System.Collections;

public class FoodStorage : MonoBehaviour {


	public static int _capacity = 100;
	public static int _currentStock = 100; 

	public static int TryTakeAmount(int amount){
		if(amount > _currentStock){
			int _amountToReturn = _currentStock;
			_currentStock=0;
			return _amountToReturn;
		}
		else{
			_currentStock -= amount;
			return amount;
		}
	}

	public static void AddTo(int amount){
		_currentStock += amount;
		if(_currentStock > _capacity){
			_currentStock = _capacity;
		}
	}


	private void OnGUI(){
		GUI.Box (new Rect (Screen.width - 150, 20, 150, 20), "Food: " + _currentStock.ToString ()); 
	}
}
