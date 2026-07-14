using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class followmouse : MonoBehaviour
{
    public Transform spawntransform;
    private Vector2 objlocation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        objlocation = spawntransform.position;
        spawntransform.position = Mouse.current.position.ReadValue();
    }
}
