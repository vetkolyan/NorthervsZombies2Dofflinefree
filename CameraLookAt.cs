using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Transform Player;
    public float smooth = 5.0f;
    public Vector3 offset = new Vector3(0, 2, -5);
    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Player.position + offset, smooth);
    }
}

