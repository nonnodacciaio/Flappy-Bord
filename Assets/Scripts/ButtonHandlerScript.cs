using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonHandlerScript : MonoBehaviour
{
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void Quit()
    {
        if (!Application.isEditor)
        {
            Application.Quit();
        }
    }
}
