using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public GameObject panelPerder;
    public GameObject player;

    private bool isGameOver = false;

    void end() {
        panelPerder.SetActive(true);
        player.SetActive(false);
        Pausar();
    }
    
    public void Pausar()
    {
        Time.timeScale = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            isGameOver = true;
        }
    }

    void Update()
    {
        if (isGameOver) {
            end();
        }
    }
}
