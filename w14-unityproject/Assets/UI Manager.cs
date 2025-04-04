using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadScene(int sceneIndex) {
        SceneManager.LoadScene(sceneIndex);
    }

}
