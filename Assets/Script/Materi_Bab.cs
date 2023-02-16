using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Materi_Bab : MonoBehaviour
{	
    public void BtnMateri_Bab1() {
        SceneManager.LoadScene("Materi_Bab1");
	}

	public void BtnMateri_Bab2()
	{
		SceneManager.LoadScene("Materi_Bab2");
	}

	public void BtnMateri_Bab3()
	{
		SceneManager.LoadScene("Materi_Bab3");
	}

	public void BtnClose() {
        SceneManager.LoadScene("Menu");
	}
}