using UnityEngine;
using UnityEngine.SceneManagement;
public class Settings : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadScene()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
