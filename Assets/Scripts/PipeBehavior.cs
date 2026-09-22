using UnityEngine;

public class PipeBehavior : MonoBehaviour
{   
    public float speed = -10f;
    public float currentTime = 0f, endtime = 8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move Pipe from right to left
        transform.position = new Vector3(transform.position.x + speed, transform.position.y);

        if (currentTime >= endtime)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
