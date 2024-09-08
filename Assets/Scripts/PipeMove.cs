using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone || transform.position.y < 2 * deadZone)
        {
            Destroy(gameObject);
        }
    }
}
