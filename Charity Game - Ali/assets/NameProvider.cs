using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NameProvider : MonoBehaviour {

	private static List<string> _maleNames = new List<string>{"Ali", "Rune"};
	private static List<string> _femaleNames = new List<string>{"Anne", "Lotte"};

	public static string GetRandomName(bool isMale){
		if(isMale){
			int randomNumber = Random.Range(0, _maleNames.Count);
			return _maleNames[randomNumber];
		}
		else{
			int randomNumber = Random.Range(0, _femaleNames.Count);
			return _femaleNames[randomNumber];
		}
	}
}
