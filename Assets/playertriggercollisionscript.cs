using UnityEngine;
using UnityEngine.SceneManagement;
public class Playertriggercollisionscript : MonoBehaviour
{
    private float countdowntime;
    private leftcollision left;
    private rightcollision right;
    private upcollision up;
    private spacecollision space;
    private void countdown()
    {
        countdowntime -= Time.deltaTime;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex > 6 && SceneManager.GetActiveScene().buildIndex < 16)
        {
            left = GameObject.Find("leftsquare").GetComponent<leftcollision>();
            right = GameObject.Find("rightsquare").GetComponent<rightcollision>();
            up = GameObject.Find("upsquare").GetComponent<upcollision>();
            space = GameObject.Find("spacesquare").GetComponent<spacecollision>();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("player entered trigger of " + collision.gameObject.name);
        if (collision.gameObject.name == "flagtrigger") 
        {
            // thing here where 1 second countdown timer counts down, if player stays in flag area for 1 seconds, win, but if not, cancel and reset timer
            Debug.Log("win after 0.5 seconds");
            countdowntime = 0.5f;
        }
        if (collision.gameObject.name == "spike")
        {
            Debug.Log("death");
            if (SceneManager.GetActiveScene().buildIndex > 6 && SceneManager.GetActiveScene().buildIndex < 16)
            {
                left.isleftheldcollision = false;
                right.isrightheldcollision = false;
                up.isupheldcollision = false;
                space.isspaceheldcollision = false;
            }
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
                countdowntime = 0.5f;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            } //you win thing here, issue where for some reason countdown time stops randomly
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        countdowntime = 0.5f;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("player collided with " + collision.gameObject.name);
    }
}
