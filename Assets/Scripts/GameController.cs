using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public GameObject menuPrincipal;
    public GameObject muroEstrella;
    public GameObject muroEstrella2;
    public GameObject muroEstrella3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        menuPrincipal.SetActive(false);
        muroEstrella.SetActive(false);
        muroEstrella2.SetActive(false);
        muroEstrella3.SetActive(false);
    }
    public void playAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void exitGame()
    {
        Application.Quit();
    }

}
