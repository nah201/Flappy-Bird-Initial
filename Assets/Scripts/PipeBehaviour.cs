using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
    public float speed = -0.01f;
    public float hSpeed = 0.005f; 
    public float currentTime = 0f, endTime = 8f;
    public bool isGoingUp = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isGoingUp = Random.value > 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        // move the pipe from right to left
        
        transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        if (isGoingUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + hSpeed,
                transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - hSpeed,
                transform.position.z);
        }

        if (currentTime <= endTime / 12) 
        {
            isGoingUp = !isGoingUp;
        }
        if (currentTime >= endTime)
        {
            GameObject.Destroy(gameObject);
        }
    }
}