using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TriBehavior : MonoBehaviour
{
    public bool isGoingup = false;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If the player presses SPACE, we add force to the rigidbody!
        if (Input.GetKeyDown(KeyCode.Space)) //If Space is pressed
        {
            if (isGoingup)
            {

                transform.Rotate(Vector3.up, 30);
                isGoingup = !isGoingup;
            }
            else
            {
                transform.Rotate(Vector3.down, 30f);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
