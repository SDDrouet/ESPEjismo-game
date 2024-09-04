using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class MenuPausa : MonoBehaviour
{
    public GameObject menuPausa;
    public bool juegoPausado = false;

    [SerializeField] TextMeshProUGUI textoCrono;

    [SerializeField] private float tiempo;

    private int tiempoMinutos, tiempoSegundos;

    void Cronometro() {
        tiempo += Time.deltaTime;
        tiempoMinutos = (int)tiempo / 60;
        tiempoSegundos = (int)tiempo % 60;
        textoCrono.text = tiempoMinutos.ToString("00") + ":" + tiempoSegundos.ToString("00");
    }

    void Start()
    {
        Reanudar();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            juegoPausado = !juegoPausado;
        }

        if (juegoPausado)
        {
            Pausar();
        }

        if (!juegoPausado) {
            Cronometro();
        }
    }

    public void Reanudar()
    {
        menuPausa.SetActive(false);
        juegoPausado = false;
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Pausar()
    {
        menuPausa.SetActive(true);
        Time.timeScale = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void menuPrincipal() {
        SceneManager.LoadScene("MainMenu");
    }
}
