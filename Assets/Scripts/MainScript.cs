using UnityEngine;
using System.Collections;
using System;

public class MainScript : MonoBehaviour
{
	void Start ()
	{
		Action a = () => Debug.Log("Nothing to see here");

        ThisTakesACallback(a);

        Action b;

        b = () => {
            Debug.Log(b.Method.Name);
        };

        b.Invoke();
	}

	void ThisTakesACallback(Action a)
	{
        ThisTakesAForwardedCallback(a ?? ThisIsWrongButItCompiles);
    }

    void ThisTakesAForwardedCallback(Action a)
    {
        Debug.Log("callback: " + a.Method.Name);
        a.Invoke();
    }

	void ThisIsWrongButItCompiles(bool wrong=false)
	{
		Debug.Log("wrong: " + wrong);
	}
}
