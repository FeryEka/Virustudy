using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt("skor").ToString();
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
