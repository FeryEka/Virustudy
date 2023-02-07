using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = PlayerPrefs.GetFloat("Nilai").ToString();
        float score = PlayerPrefs.GetFloat("Nilai");
        if (score >= 90)
        {
            PlayerPrefs.SetString("Nilai", "A");
        }
        else if (score >= 75)
        {
            PlayerPrefs.SetString("Nilai", "B");
        }
        else if (score >= 60)
        {
            PlayerPrefs.SetString("Nilai", "C");
        }
        else
        {
            PlayerPrefs.SetString("Nilai", "D");
        }
        GetComponent<Text>().text = PlayerPrefs.GetString("Nilai");
    }

    public void btnSelesai()
    {
        StartCoroutine(DelaybtnLanjut());
    }
    IEnumerator DelaybtnLanjut()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Menu");
    }
}
