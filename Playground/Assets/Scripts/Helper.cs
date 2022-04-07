using UnityEngine;
using UnityEngine.SceneManagement;

public class Helper : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            ReloadScene();
        }
    }

    private void ReloadScene()
    {
        Debug.Log("Reload scene");
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
