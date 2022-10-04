using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Remove this later, just for reference
public class CalculatorScript
{
    public static int Add(int n1, int n2)
    {
        int sum = n1 + n2;
        return sum;
    }

    public static int Subtract(int n1, int n2)
    {
        int sub = n1 - n2;
        return sub;
    }
}

public class GameManagerScript : MonoBehaviour
{
    // Singleton Code
    private static GameManagerScript _Instance = null;
    public static GameManagerScript Instance
    {
        get
        {
            if (_Instance == null)
            {
                _Instance = (GameManagerScript)FindObjectOfType(typeof(GameManagerScript));
            }

            return _Instance;
        }
    }

    public bool IsGameOver = false;
}
