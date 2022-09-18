using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void BtnMateri() {
        SceneManager.LoadScene("Materi");
	}
	
	public void BtnKuis() {
        SceneManager.LoadScene("Kuis");
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