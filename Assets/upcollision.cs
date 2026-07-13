using UnityEngine;

public class upcollision : MonoBehaviour
{
    public bool isupheldcollision;
    public bool isupheld()
    {
        if (isupheldcollision) { return true; }
        else { return false; }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //change to pressed key (greyed out)
        isupheldcollision = true;
        Debug.Log("right");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isupheldcollision = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        //unpress key (ungreyout)
        isupheldcollision = false;
        Debug.Log("no right");
    }
}
