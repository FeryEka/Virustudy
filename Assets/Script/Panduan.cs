using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panduan : MonoBehaviour
{	
    public void BtnClose() {
        SceneManager.LoadScene("Menu");
	}
}