using UnityEngine;
using System.Collections;

public class Citizen : MonoBehaviour {

	private string _name;
	private int _age;
	private bool _isMale;
	private int _health;
	private int _hunger;
	private int _foodRequirement = 10;
    private int _waterRequirment = 10; 
	private int _thurst;
	private int _happiness;
	private int _knowledge;
	private int _income;
	private string _job;

	public void UpdateAgeOfCitizen(){
		_age++;
		if(_age==30){
			Die();
		}
	}

	public void UpdateHunger(){
		_hunger += _foodRequirement;
	}

	public bool HasDiedFromHunger(){
		return _hunger > 100;
	}


    public void UpdateThurst()
    {
        _thurst += _waterRequirment; 
    }

    public bool HasDiedFromThurst()
    {
        return _thurst > 100; 
    }

	public void Eat(){
		int foodAvailableForMe = FoodStorage.TryTakeAmount(_foodRequirement);
		_hunger -= foodAvailableForMe;
	}

    public void Drink() {
        int waterAvailableForME = WaterStorage.TryTakeAmount(_waterRequirment);
        _thurst -= waterAvailableForME; 
    }

    public void Die(){
		CitizenMaster.CitizenDied(this);
	}

	public string name{
		set{
			_name = value;
		}
		get{
			return _name;
		}
	}

	public int age{
		set{
			_age = value;
		}
		get{
			return _age;
		}
	}

	public int health{
		get{
			return _health;
		}
	}

	public int hunger{
		get{
			return _hunger;
		}
	}

    public bool isMale
    {
        set
        {
            _isMale = value;
        }
        get
        {
            return _isMale;
        }
    }

    public string job{
        set
        {
            _job = value; 
        }
		get{
			return _job;
		}
	}

    public int income
    {
        set
        {
            _income = value; 
        }
        get
        {
            return _income; 
        }
    }
}
