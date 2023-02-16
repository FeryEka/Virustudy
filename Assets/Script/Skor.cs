using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour
{
	void Start() 
	{
		PlayerPrefs.SetInt("Nilai", 0);
	}
	
    void Update()
    {
		GetComponent<Text>().text = PlayerPrefs.GetInt("Nilai").ToString();
    }
}