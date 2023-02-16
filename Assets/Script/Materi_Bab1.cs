using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Materi_Bab1 : MonoBehaviour
{
	public void BtnAugmentedReality() {
		SceneManager.LoadScene("AR_Bab1");
	}
	
    public void BtnClose() {
        SceneManager.LoadScene("Materi_Pilih_Bab");
	}
}