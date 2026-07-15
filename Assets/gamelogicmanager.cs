using UnityEngine;
using UnityEngine.SceneManagement;

public class gamelogicmanager : MonoBehaviour
{
    private bool mousedown;
    public bool dropobject() 
    {
        if (mousedown && SceneManager.GetActiveScene().buildIndex > 7) /* && another boolean for if the object will be placed inside of a wall, and if so, set dropobject to false && another boolean for if there are any objects left that you can drop with the mouse*/ { return true; }
        else { return false; }
    }
    private void OnMouseDown()
    {
        mousedown = true;
    }
    private void OnMouseUp()
    {
        mousedown = false;
    }

}
