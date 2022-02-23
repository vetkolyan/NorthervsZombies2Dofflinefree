using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript : MonoBehaviour
{
        public void restartScene()
    {
        SceneManager.LoadScene ("SampleScene");
    }
}
