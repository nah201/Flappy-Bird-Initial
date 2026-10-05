using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    //timer of description
    public float currentTime = 0f, endTime = 3f;
    public GameObject pipePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= endTime ) 
        {
            Vector2 newPipePos = new Vector2(transform.position.x, transform.position.y + Random.Range(-3f, 3f));
            GameObject newPipe = Instantiate(pipePrefab, newPipePos, transform.rotation);
            currentTime = 0f;
        }
    }
}