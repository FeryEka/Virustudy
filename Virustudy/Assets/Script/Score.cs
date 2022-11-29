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
        GetComponent<Text>().text = PlayerPrefs.GetInt("skor").ToString();
        int score = PlayerPrefs.GetInt("skor");
        if (score >= 90)
        {
            PlayerPrefs.SetString("score", "A");
        }
        else if (score >= 75)
        {
            PlayerPrefs.SetString("score", "B");
        }
        else if (score >= 60)
        {
            PlayerPrefs.SetString("score", "C");
        }
        else
        {
            PlayerPrefs.SetString("score", "D");
        }
        GetComponent<Text>().text = PlayerPrefs.GetString("score");
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
