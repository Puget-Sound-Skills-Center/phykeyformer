using UnityEngine;

public class leftcollision : MonoBehaviour
{
    public bool isleftheldcollision;
    public bool isleftheld()
    {
        if (isleftheldcollision) { return true; }
        else { return false; }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //change to pressed key (greyed out)
        isleftheldcollision = true;
        Debug.Log("right");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isleftheldcollision = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        //unpress key (ungreyout)
        isleftheldcollision = false;
        Debug.Log("no right");
    }
}
