using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panduan : MonoBehaviour
{	
    public void BtnBack()
	{
		StartCoroutine(DelayButtonKeluar());
	}
	IEnumerator DelayButtonKeluar()
	{
		yield return new WaitForSeconds(0.3f);
		SceneManager.LoadScene("Menu");
	}
}