using System.Runtime.CompilerServices;  
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class JumpBehaviour : MonoBehaviour
{
    // A reference to the rigidbody (Basically naming it)
    //Ctrl S to save 
    // ; tells the compiler when the end of the line it so it doesnt go into multiple lines 
    public Rigidbody2D rb;
    public bool isDead = false;
    public float jumpforce = 8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioSource audioSource;
    public AudioClip deathSound;
    public float deathTimer = 0f, reloadTimerLength = 3f;
    public float deathThrowForce = 25f;
    

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
            if (Input.GetKeyDown(KeyCode.Space) && isDead == false)
            {
                rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
                audioSource.pitch = Random.Range(0.9f, 1.1f);
                audioSource.Play();
            }
            if (isDead == true)
            {
                deathTimer += Time.deltaTime;
                if (deathTimer >= reloadTimerLength)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        audioSource.PlayOneShot(deathSound);
        transform.GetChild(0).gameObject.SetActive(true);
        rb.AddForce(Vector2.left * deathThrowForce, ForceMode2D.Impulse);
        isDead = true;
    }

    
}
