using UnityEngine;
using UnityEngine.SceneManagement;

namespace Prefabs
{
    public class Pauza : MonoBehaviour
    {
        public static bool isPaused = false;

        void Update()
        {
            if(SceneManager.GetActiveScene().name == "Game"){
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    if (isPaused)
                        Resume();
                    else
                        Pause();
                }
            }
        }

        public void Resume()
        {
            Time.timeScale = 1f;
            isPaused = false;
            Debug.Log("Game Resumed");
        }

        void Pause()
        {
            Time.timeScale = 0f;
            isPaused = true;
            Debug.Log("Game Paused");
        }
    }
}
