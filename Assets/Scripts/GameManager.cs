using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private string game = "Game";
    [SerializeField] private string crew = "Current Crew";
    [SerializeField] private string main = "Main Menu";

    public void StartGameButton()
    {
        SceneManager.LoadScene(game);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }

    public void CrewManifestButton()
    {
        SceneManager.LoadScene(crew);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(main);
    }
}
