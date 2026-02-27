using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMeni : MonoBehaviour
{
    void Update()
    {
        GoBack();
    }

    public void GoBack()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
