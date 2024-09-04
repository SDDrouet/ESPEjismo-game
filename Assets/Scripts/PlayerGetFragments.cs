using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerGetFragments : MonoBehaviour
{
    public int fragmentos = 0;
    public int fragmentosTotales = 8;
    public GameObject player;

    [SerializeField] TextMeshProUGUI textoFragmentos;
    [SerializeField] TextMeshProUGUI textoTomarFragmento;

    private bool thereIsFragment = false;
    private GameObject fragmentObject = null;

    //sonido de fragmento
    public AudioSource audioSource;
    public AudioClip fragmentSound;

    public GameObject panelGanar;


    void win() {
        panelGanar.SetActive(true);
        player.SetActive(false);
        Pausar();
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
    }

    
    public void Pausar()
    {
        Time.timeScale = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void regregarMenu() {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {

        if (thereIsFragment) {
            if (Input.GetKeyDown(KeyCode.E)) {
                fragmentos++;
                textoFragmentos.text = fragmentos + "/" + fragmentosTotales;
                Destroy(fragmentObject);
                audioSource.PlayOneShot(fragmentSound);
                thereIsFragment = false;
                textoTomarFragmento.gameObject.SetActive(false);
                fragmentObject = null;
            }
        }

        if (fragmentos == fragmentosTotales) {
            win();
        }

        
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("fragment")) {
            // mostrar texto para tomar fragmento
            textoTomarFragmento.gameObject.SetActive(true);
            thereIsFragment = true;
            fragmentObject = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("fragment")) {
            textoTomarFragmento.gameObject.SetActive(false);
            thereIsFragment = false;
            fragmentObject = null;
        }
    }
}
