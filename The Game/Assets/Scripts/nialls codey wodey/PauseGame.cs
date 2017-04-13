using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour {

    public Transform canvas;
    public Transform pauseMenu;
    public Transform optionsMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
	}

    public void Pause()
    {
         if (canvas.gameObject.activeInHierarchy == false)
            {
                if (pauseMenu.gameObject.activeInHierarchy == false)
                {
                    pauseMenu.gameObject.SetActive(true);
                    optionsMenu.gameObject.SetActive(false);
                }
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
     }

    public void Escape()
    {
        SceneManager.LoadScene("Solo Menu");
    }

    public void Options(bool Open)
    {
        if (Open)
        {
            optionsMenu.gameObject.SetActive(true);
            pauseMenu.gameObject.SetActive(false);
        }
        else
        {
            optionsMenu.gameObject.SetActive(false);
            pauseMenu.gameObject.SetActive(true);
        }
    }
 
}
