using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void BtnMateriPilihBab() {
		StartCoroutine(DelayButtonMateri());
	}
	IEnumerator DelayButtonMateri()
	{
		yield return new WaitForSeconds(0.3f);
		SceneManager.LoadScene("Materi_Pilih_Bab");
	}
	
	public void BtnKuis()
	{
		StartCoroutine(DelayButtonKuis());
	}
	IEnumerator DelayButtonKuis()
	{
		yield return new WaitForSeconds(0.3f);
		SceneManager.LoadScene("Kuis");
	}
	
	public void BtnPanduan()
	{
		StartCoroutine(DelayButtonPanduan());
	}
	IEnumerator DelayButtonPanduan()
	{
		yield return new WaitForSeconds(0.3f);
		SceneManager.LoadScene("Panduan");
	}
	
	public void BtnTentang()
	{
		StartCoroutine(DelayButtonTentang());
	}
	IEnumerator DelayButtonTentang()
	{
		yield return new WaitForSeconds(0.3f);
		SceneManager.LoadScene("Informasi");
	}
	
	public void BtnKeluar()
	{
		StartCoroutine(DelayButtonKeluar());
	}
	IEnumerator DelayButtonKeluar()
	{
		yield return new WaitForSeconds(0.3f);
		Debug.Log("Close");
		Application.Quit();
	}
	
	/* 
	public void BtnClose() {
	    Debug.Log("Close");
        Application.Quit();
	}
	*/
}