using UnityEngine;
using UnityEngine.Events;

public class PauseScript : MonoBehaviour
{
    public event UnityAction<bool> Pause;

    public void ResumeGame(bool p)
    {
        Pause?.Invoke(p);
        Time.timeScale = p ? 0f : 1f;
    }
}
