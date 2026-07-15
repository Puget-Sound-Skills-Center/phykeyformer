using UnityEngine;
using UnityEngine.SceneManagement;
public class Playertriggercollisionscript : MonoBehaviour
{
    private float countdowntime;
    
    private void countdown()
    {
        countdowntime -= Time.deltaTime;
        Debug.Log(countdowntime);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("player entered trigger of " + collision.gameObject.name);
        if (collision.gameObject.name == "flagtrigger") 
        {
            // thing here where 1 second countdown timer counts down, if player stays in flag area for 1 seconds, win, but if not, cancel and reset timer
            Debug.Log("win after 1 second");
            countdowntime = 1.0f;
        }
        if (collision.gameObject.name == "spike")
        {
            Debug.Log("death");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "flagtrigger") 
        {
            countdown();
            if (countdowntime <= 0f) 
            {
                countdowntime = 1f;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
            } //you win thing here, issue where for some reason countdown time stops randomly
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        countdowntime = 1.0f;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("player collided with " + collision.gameObject.name);
    }
}
