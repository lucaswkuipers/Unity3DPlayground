using UnityEngine;

internal class Quitter : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Quit game");
            Application.Quit();
        }
    }
}
