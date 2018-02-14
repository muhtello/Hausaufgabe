using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void LoadScene (int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void LoadNextScene()
    {
        LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
