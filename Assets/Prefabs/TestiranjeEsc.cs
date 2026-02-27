using UnityEngine;
using UnityEngine.SceneManagement;

namespace Prefabs
{
    public class TestiranjeEsc : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (SceneManager.GetActiveScene().name != "Main Menu")
                {
                    Debug.Log("Radi!!");
                }
            }
        }
    }
}
