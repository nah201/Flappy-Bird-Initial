using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpBehaviour : MonoBehaviour
{
    // A reference to the rigidbody (Basically naming it)
    //Ctrl S to save 
    // ; tells the compiler when the end of the line it so it doesnt go into multiple lines 
    public Rigidbody2D rb;
    public float jumpforce = 8f;
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
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse); //Adds a jumpforce of 200 to the object, basically just makes it jump 200 whenever space is pressed.
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
