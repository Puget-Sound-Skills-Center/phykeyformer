using UnityEngine;
using UnityEngine.SceneManagement;

public class gamelogicmanager : MonoBehaviour
{
    private bool mousedown;
    public bool dropobject() 
    {
        if (mousedown && SceneManager.GetActiveScene().buildIndex > 7) { return true; }
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
