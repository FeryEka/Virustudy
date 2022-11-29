using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kuis : MonoBehaviour
{	
    public void btnLanjut()
	{
		StartCoroutine(DelaybtnLanjut());
	}
	IEnumerator DelaybtnLanjut()
	{
		yield return new WaitForSeconds(0.3f);
		SceneManager.LoadScene("Nilai");
	}
}