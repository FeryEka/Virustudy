using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jawab : MonoBehaviour
{
    public GameObject benar, salah;

    public void jawaban(bool jawab)
    {
        if (jawab)
        {
            benar.SetActive(false);
            benar.SetActive(true);
            int skor = PlayerPrefs.GetInt("skor") + 10;
            PlayerPrefs.SetInt("skor", skor);
        }
        else
        {
            salah.SetActive(false);
            salah.SetActive(true);
        }
        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);

    }

    public void btnBack()
    {
        StartCoroutine(DelaybtnBack());
    }
    IEnumerator DelaybtnBack()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Menu");
    }

    void Update() {
		
    }
}