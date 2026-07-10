using UnityEngine;

public class rightcollision : MonoBehaviour
{
    public bool isrightheld = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //change to pressed key (greyed out)
        isrightheld = true;
        Debug.Log("right");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isrightheld = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        //unpress key (ungreyout)
        isrightheld = false;
        Debug.Log("no right");
    }
}
