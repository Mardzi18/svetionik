using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels2 : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadSceneAsync(5);
    }
}
