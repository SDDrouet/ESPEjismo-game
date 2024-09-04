using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUtils : MonoBehaviour
{
    public void regresarMenu() {
        SceneManager.LoadScene("MainMenu");
    }
}
