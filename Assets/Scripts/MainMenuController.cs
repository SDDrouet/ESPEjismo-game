using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject controles;
    public GameObject menuPrincipal;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void escenaJuego() {
        SceneManager.LoadScene("GameScene");
    }

    public void menuControlesShow() {
        controles.SetActive(true);
        menuPrincipal.SetActive(false);
    }

    public void menuPrincipalShow() {
        controles.SetActive(false);
        menuPrincipal.SetActive(true);
    }

    public void salir() {
        Application.Quit();
    }
}
