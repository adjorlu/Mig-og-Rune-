using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CitizenMaster : MonoBehaviour {

	private static int _amountOfCitizensAtStart = 5;
	private static List<Citizen> _citizens = new List<Citizen>();
    private static int _numberFemale = 0;
    private static int _numberMale;

    private static int _FemaleAgeToGetKids = 9;
    private static int _MaleAgeToMakeKids = 15; 
    
    public static int _tottalIncome;

	public static void Init(){
		for(int i=0; i<_amountOfCitizensAtStart; i++){
			GameObject newCitizen = CitizenCreator.CreateCitizen(false);
			_citizens.Add(newCitizen.GetComponent<Citizen>());
		}
	}


    public static int calcCulateIncome(Citizen citizenIncome)
    {
        
       _tottalIncome= citizenIncome.income;

        return _tottalIncome;
    }


    public static void UpdateCitizens(){
        _tottalIncome = 0;
        _numberFemale = 0;
        _numberMale = 0; 
		for(int i=_citizens.Count-1; i>=0; i--){
			_citizens[i].UpdateAgeOfCitizen();
			_citizens[i].UpdateHunger();
			_citizens[i].Eat();
            _citizens[i].UpdateThurst();
            _citizens[i].Drink(); 
            Money.AddTo(_citizens[i].income);
            _tottalIncome += _citizens[i].income;
            if (_citizens[i].isMale == true && _citizens[i].age > _MaleAgeToMakeKids)
            {
                _numberMale += 1;
            }
            else if (_citizens[i].age > _FemaleAgeToGetKids)
            {
                _numberFemale += 1;
            }
            
            
			if(_citizens[i].HasDiedFromHunger()){ 
				_citizens[i].Die();
			}

            if(_citizens[i].HasDiedFromThurst())
            {
                _citizens[i].Die();
            }
            
		}
        if (Clock._newBornYear == 3 && _numberMale != 0)
        {
            for (int f = 0; f < _numberFemale; f++)
            {
                newBabyIsBorn();
            }
        }
    }

    public static void newBabyIsBorn()
    {     
            GameObject newCitizen = CitizenCreator.CreateCitizen(true);
            _citizens.Add(newCitizen.GetComponent<Citizen>());
    }

	public static void CitizenDied(Citizen citizen){
		_citizens.Remove(citizen);
		Destroy(citizen.gameObject);
	}

	public static List<Citizen> GetCitizens(){
		return _citizens;
	}


    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width - 150, 0, 150, 20), "tottal income: " + _tottalIncome.ToString());
        GUI.Box(new Rect(0, 40, 200, 20), "Number of Citizens: " + _citizens.Count.ToString());
        GUI.Box(new Rect(0, 60, 200, 20), "MAN MAN: " + _numberMale);
        GUI.Box(new Rect(200, 60, 200, 20), "Girly girl: " + _numberFemale);
       // GUI.Box(new Rect(200, 80, 200, 20), "Girly girl: " + Clock._newBornYear);

    }
}
