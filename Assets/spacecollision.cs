using UnityEngine;

public class spacecollision : MonoBehaviour
{
    public bool isspaceheldcollision;
    public bool isspaceheld()
    {
        if (isspaceheldcollision) { return true; }
        else { return false; }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //change to pressed key (greyed out)
        isspaceheldcollision = true;
        Debug.Log("right");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isspaceheldcollision = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        //unpress key (ungreyout)
        isspaceheldcollision = false;
        Debug.Log("no right");
    }
}
