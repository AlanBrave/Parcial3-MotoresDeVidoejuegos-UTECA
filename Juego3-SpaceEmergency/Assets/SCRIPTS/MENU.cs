using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("JUEGO");
    }

    public void Salir()
    {
        Application.Quit();

    }

    public void EscenaMainMenu()
    {
        SceneManager.LoadScene("MENU");

    }

    public void EscenaInfoS()
    {
        SceneManager.LoadScene("INSTRUCCIONES");
    }
    public void EscenaOPCIONES()
    {
        SceneManager.LoadScene("OPCIONES");
    }
}
