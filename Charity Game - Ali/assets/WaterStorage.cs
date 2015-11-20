using UnityEngine;
using System.Collections;

public class WaterStorage : MonoBehaviour
{

    public static int _Watercapacity = 100;
    public static int _currentWaterStock = 100;

    public static int TryTakeAmount(int amount)
    {
        if (amount > _currentWaterStock)
        {
            int _amountToReturn = _currentWaterStock;
            _currentWaterStock = 0;
            return _amountToReturn;
        }
        else
        {
            _currentWaterStock -= amount;
            return amount;
        }
    }


    public static void AddTo(int amount)
    {
        _currentWaterStock += amount;
        if (_currentWaterStock > _Watercapacity)
        {
            _currentWaterStock = _Watercapacity;
        }
    }


    private void OnGUI()
    {
        GUI.Box(new Rect(Screen.width - 150, 40, 150, 20), "Water: " + _currentWaterStock.ToString());
    }
}
