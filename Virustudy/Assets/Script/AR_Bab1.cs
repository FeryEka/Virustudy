using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AR_Bab1 : MonoBehaviour
{
	public void btnAugmentedReality() {
		SceneManager.LoadScene("AR_Bab1");
	}
	
    public void btnBack() {
        SceneManager.LoadScene("Materi_Pilih_Bab");
	}
}