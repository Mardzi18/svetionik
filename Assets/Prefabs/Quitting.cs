using System;
using UnityEngine;

public class Quitting : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
