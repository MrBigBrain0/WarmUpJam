using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit_Button : MonoBehaviour
{
   public void quitGame()
    {
        // if the game is running, pressing guit exits the application and ends the build run.

        Application.Quit();

        Application.Quit();
    }
}
