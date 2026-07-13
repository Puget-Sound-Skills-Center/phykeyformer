using UnityEngine;

public class upcollision : MonoBehaviour
{
    public bool isupheld;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //change to pressed key (greyed out)
        isupheld = true;
        Debug.Log("up");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isupheld = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        //unpress key (ungreyout)
        isupheld = false;
        Debug.Log("no up");
    }
}
