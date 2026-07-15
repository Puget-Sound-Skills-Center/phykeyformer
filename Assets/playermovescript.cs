using UnityEngine;
using UnityEngine.SceneManagement;

/* uhh so things to add:

coyote jumping
the entire physics pressing on button stuff (oh boy)
    consists of adding the dropping physics objects part
level system DONE
flag trigger DONE

issues:
    the very slight holes in the floor due to the floor being many objects causes dynamic objects to get "kicked up" (particularly the square)
    uhh idk
 */
public class playermovescript : MonoBehaviour
{

    //note to self, for some reason .getComponent<Position>(); does not work, so you have to use .transform.position i guess?
    private grounded groundscript;
    public Rigidbody2D body;
    private float timer;
    private bool cancurrentlyjump;
    private leftcollision left;
    private rightcollision right;
    private upcollision up;
    private spacecollision space;
    [SerializeField] private float speed;
    [SerializeField] private float jumpheight;
    [SerializeField] private float acceleration; //maybe?
    void Start()
    {
        cancurrentlyjump = false;
        groundscript = GameObject.FindWithTag("grounded").GetComponent<grounded>();

        if (SceneManager.GetActiveScene().buildIndex > 6)
        {
            left = GameObject.Find("leftsquare").GetComponent<leftcollision>(); //note to self, reference correct object inside GameObject.Find("")
            Debug.Log("left is " + left);
            right = GameObject.Find("rightsquare").GetComponent<rightcollision>();
            Debug.Log("left is " + right);
            up = GameObject.Find("upsquare").GetComponent<upcollision>();
            Debug.Log("left is " + up);
            space = GameObject.Find("spacesquare").GetComponent<spacecollision>();
            Debug.Log("left is " + space);
        }
        //eventually findwithtag honestly
    }
    void Update()
    {
        if (!cancurrentlyjump && groundscript.canjump())
        {
            cancurrentlyjump = true;
        }
        else { cancurrentlyjump = false; }
        
        if (SceneManager.GetActiveScene().buildIndex <= 6) //Make sure to change this number to the number of the scene where you want the new input system to start working
        {
            if (!(Input.GetKey(KeyCode.LeftArrow) & Input.GetKey(KeyCode.RightArrow)))
            {
                body.linearVelocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, body.linearVelocity.y);
            }
        }
        else
        {
            if (!(left.isleftheld() && right.isrightheld())) 
            {
                if (right.isrightheld())
                {
                    body.linearVelocity = new Vector2(speed, body.linearVelocity.y);
                    Debug.Log("yo right works");
                }

                else if (left.isleftheld())
                {
                    body.linearVelocity = new Vector2(-speed, body.linearVelocity.y);
                    Debug.Log("yo left works");
                }
            }

        }
        if (SceneManager.GetActiveScene().buildIndex <= 6) //Make sure to change this number to the number of the scene where you want the new input system to start working
        {
            if (((Input.GetKeyDown(KeyCode.UpArrow)) || (Input.GetKeyDown(KeyCode.Space))) && groundscript.canjump()) // && canjump boolean from other thing (&& grounddetection.canjump) DONE
            //if pressed, turn canjump to false, but when touching the ground again, turn canjump to true
            {
                body.linearVelocity = new Vector2(body.linearVelocity.x, jumpheight);
                Debug.Log("player jumped");
            }
        }
        else
        {
            if (up.isupheld() || space.isspaceheld())
            { 
                Debug.Log("yo up/space works");
                body.linearVelocity = new Vector2(body.linearVelocity.x, jumpheight); 
            }
        }
    }
}
 