using UnityEngine;

public class rightcollision : MonoBehaviour
{
    public bool isrightheldcollision;
    public bool isrightheld()
    {
        if (isrightheldcollision) { return true; }
        else { return false; }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isrightheldcollision = true;
        Debug.Log("right");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isrightheldcollision = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isrightheldcollision = false;
        Debug.Log("no right");
    }
}