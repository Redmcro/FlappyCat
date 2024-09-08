using UnityEngine.SceneManagement;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
