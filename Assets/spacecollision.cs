using UnityEngine;

public class spacecollision : MonoBehaviour
{
    public bool isspaceheld;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //change to pressed key (greyed out)
        isspaceheld = true;
        Debug.Log("space");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isspaceheld = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        //unpress key (ungreyout)
        isspaceheld = false;
        Debug.Log("no space");
    }
}
