using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class popup : MonoBehaviour
{
    public GameObject PopUp;
    public GameObject bg;
    public bool aktif;
	// Start is called before the first frame update
	public void BtnPanduan()
	{
		gameObject.SetActive(aktif);
	}

    void OnMouseDown()
    {
		PopUp.SetActive(aktif);
    }

    public void BtnTentang()
	{
		SceneManager.LoadScene("Informasi");
	}

	public void BtnKeluar()
	{
		Application.Quit();
	}
}
