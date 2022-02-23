using UnityEngine;

public class PauseUiScript : MonoBehaviour
{
    [SerializeField] private PauseScript pauseScript;
    public GameObject PauseScreen;
    public GameObject PauseButton;

    private void OnEnable()
    {
        pauseScript.Pause += OnPause;
    }

    private void OnDisable()
    {
        pauseScript.Pause -= OnPause;
    }

    private void OnPause(bool paused)
    {
        PauseScreen.SetActive(paused);
        PauseButton.SetActive(!paused);
    }
}
