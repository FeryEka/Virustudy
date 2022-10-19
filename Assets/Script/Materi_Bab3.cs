using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Materi_Bab3 : MonoBehaviour
{
	public void BtnAugmentedReality() {
		SceneManager.LoadScene("AR_Bab3");
	}
	
    public void BtnClose() {
        SceneManager.LoadScene("Materi_Pilih_Bab");
	}
}