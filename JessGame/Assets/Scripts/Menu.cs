using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public string firstScene;
    public TextMeshProUGUI SessDisplay;
    public void StartGame()
    {
        SceneManager.LoadScene(firstScene);
        
    }

    public void OnConnect(int sessionNumber)
    {
        SessDisplay.text = $"session: {sessionNumber}";
    }

    public void OnError(string error)
    {
        SessDisplay.text = error;
    }
}
