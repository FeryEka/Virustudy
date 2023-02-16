using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AugmentedReality : MonoBehaviour
{
	//---------------Script untuk Scene Materi masuk ke AR---------------
	public void btnArBab1()
	{
		StartCoroutine(DelaybtnAr());
	}
	IEnumerator DelaybtnAr()
	{
		yield return new WaitForSeconds(0.3f);
		SceneManager.LoadScene("AR_Bab1");
	}

	public void btnArBab2()
	{
		StartCoroutine(DelayAr2());
	}
	IEnumerator DelayAr2()
	{
		yield return new WaitForSeconds(0.3f);
		SceneManager.LoadScene("AR_Bab2");
	}

	public void btnArBab3()
	{
		StartCoroutine(DelayAr3());
	}
	IEnumerator DelayAr3()
	{
		yield return new WaitForSeconds(0.3f);
		SceneManager.LoadScene("AR_Bab3");
	}
	//------------------------------------------------------------------
	//-----------------Script untuk btn Scene Back di Ar----------------
	public void btnBackAr1()
	{
		StartCoroutine(DelayBtnBackAr1());
	}
	IEnumerator DelayBtnBackAr1()
	{
		yield return new WaitForSeconds(0.3f);
		SceneManager.LoadScene("Materi_Bab1");
	}
	public void btnBackAr2()
	{
		StartCoroutine(DelayBtnBackAr2());
	}
	IEnumerator DelayBtnBackAr2()
	{
		yield return new WaitForSeconds(0.3f);
		SceneManager.LoadScene("Materi_Bab2");
	}

	public void btnBackAr3()
	{
		StartCoroutine(DelayBtnBackAr3());
	}
	IEnumerator DelayBtnBackAr3()
	{
		yield return new WaitForSeconds(0.3f);
		SceneManager.LoadScene("Materi_Bab3");
	}
	//------------------------------------------------------------------
	//---Script untuk btn Scene Back di materi ke Pilihan menu materi---
	public void btnBackMenuMateri()
	{
		{
			StartCoroutine(DelaybtnBackMenuMateri());
		}
		IEnumerator DelaybtnBackMenuMateri()
		{
			yield return new WaitForSeconds(0.3f);
			SceneManager.LoadScene("Materi_Pilih_Bab");
		}
	}
}