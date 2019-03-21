using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {


    public Button btnStart;
    public Button quit;
    bool start = false;
 
    // Use this for initialization
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        quit.onClick.AddListener(QuitGame);
        if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            btnStart.onClick.AddListener(StartGame);
           
            if (start == true)
            {
                Debug.Log("hello");

                SceneManager.LoadScene("SampleScene");
                SceneManager.LoadScene(1);
                Invoke("MainMenu", 1f);
            }
        }

    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void StartGame()
    {
        start = true;
     
       
       
    }
}
