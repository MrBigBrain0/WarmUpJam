using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button : MonoBehaviour
{
    
    public void playGame()
    {
        // if Play is pressed, load the name by the name: ("example scene")
        SceneManager.LoadScene("SampleScene");
    }

}
