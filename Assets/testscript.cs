using UnityEngine;

public class testscript : MonoBehaviour
{
    [SerializeField] private LayerMask groundlayer;
    public bool isbuttonheld()
    {
        if (Physics2D.BoxCast(transform.position, transform.localScale, transform.rotation.z, transform.up, 0, groundlayer)) { return true; }
        else { return false; }
    }
}
