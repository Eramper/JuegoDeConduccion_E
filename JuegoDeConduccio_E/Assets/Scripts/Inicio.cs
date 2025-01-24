using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    // Update is called once per frame
    public void ExitGame()
    {
        print("Hasta luego");
        Application.Quit();
    }
    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
            print("Hasta luego");
        }
    }
}
