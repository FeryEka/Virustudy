using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Virustudy : MonoBehaviour
{
    public void Lanjut() {
        StartCoroutine(DelayButtonLanjut());
	}
    IEnumerator DelayButtonLanjut()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Menu");

    }
}