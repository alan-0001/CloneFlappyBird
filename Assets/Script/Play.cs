using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void StartGame(string cena)
    {
        SceneManager.LoadScene(cena);
    }
    public void Sair()
    {
        Application.Quit();
    }
}
