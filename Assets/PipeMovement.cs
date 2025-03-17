using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadZone = -45;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; // Time.deltaTime = sync code to time NOT frames

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
