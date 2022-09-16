using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Materi : MonoBehaviour
{
	public void BtnAugmentedReality() {
		SceneManager.LoadScene("AugmentedReality");
	}
	
    public void BtnClose() {
        SceneManager.LoadScene("Menu");
	}
}