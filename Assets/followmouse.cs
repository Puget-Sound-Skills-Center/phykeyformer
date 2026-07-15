using UnityEngine;
using UnityEngine.InputSystem;

public class followmouse : MonoBehaviour
{
    public Transform spawntransform;
    void Update()
    {
        Debug.Log(Screen.currentResolution);
        Debug.Log(Mouse.current.position.ReadValue().x);
        Debug.Log(Mouse.current.position.ReadValue().y);
        transform.position = new Vector2(((Mouse.current.position.ReadValue().x - Screen.currentResolution.width/2) / (Screen.currentResolution.height/10)), ((Mouse.current.position.ReadValue().y - Screen.currentResolution.height/2) / (Screen.currentResolution.height/10))); 
        //make this work for all resolution if possible
        Debug.Log(transform.position);
        //(Mouse.current.position.ReadValue().x-1440)/(Screen.currentResolution.x/10)f;
        //(Mouse.current.position.ReadValue().y-720)/(Screen.current.Resolution.x/10)f;
    }
}
