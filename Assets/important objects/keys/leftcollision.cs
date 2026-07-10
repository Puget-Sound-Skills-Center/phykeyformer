using UnityEngine;

public class leftcollision : MonoBehaviour
{
    public bool isleftheld = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //change to pressed key (greyed out)
        isleftheld = true;
        Debug.Log("left");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isleftheld = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        //unpress key (ungreyout)
        isleftheld = false;
        Debug.Log("no left");
    }
}
