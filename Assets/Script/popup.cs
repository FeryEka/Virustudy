using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class popup : MonoBehaviour
{
    public GameObject PopUp1, PopUp2, PopUp3, PopUp4;
    public GameObject bg;
    public bool aktif;
	// Start is called before the first frame update

	void OnMouseDown()
	{
		PopUp1.SetActive(aktif);
		PopUp2.SetActive(aktif);
		PopUp3.SetActive(aktif);
		PopUp4.SetActive(aktif);
	}

	public void BtnPanduan()
	{
		StartCoroutine(DelaybtnPanduan());
	}
	IEnumerator DelaybtnPanduan()
	{
		yield return new WaitForSeconds(0.3f);
		SceneManager.LoadScene("Panduan");
	}

    public void BtnTentang()
	{
		StartCoroutine(DelaybtnTentang());
	}
	IEnumerator DelaybtnTentang()
	{
		yield return new WaitForSeconds(0.3f);
		SceneManager.LoadScene("Informasi");
	}

	public void BtnKeluar()
	{
		StartCoroutine(DelaybtnBack());
	}
	IEnumerator DelaybtnBack()
	{
		yield return new WaitForSeconds(0.3f);
		Application.Quit();
	}
}
