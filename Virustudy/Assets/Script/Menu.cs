using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void BtnMateriPilihBab() {
        SceneManager.LoadScene("Materi_Pilih_Bab");
	}
	
	public void BtnKuis() {
        SceneManager.LoadScene("Kuis");
	}
	
	public void BtnPanduan() {
        SceneManager.LoadScene("Panduan");
	}
	
	public void BtnInformasi() {
        SceneManager.LoadScene("Informasi");
	}
	
	public void BtnClose() {
        SceneManager.LoadScene("Virustudy");
	}
	
	/* 
	public void BtnClose() {
	    Debug.Log("Close");
        Application.Quit();
	}
	*/
}