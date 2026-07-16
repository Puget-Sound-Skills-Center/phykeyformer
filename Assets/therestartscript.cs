using UnityEngine;
using UnityEngine.SceneManagement;
public class therestartscript : MonoBehaviour
{
    public int currentindex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentindex = SceneManager.GetActiveScene().buildIndex;
    }
    public void reloadscene() 
    {
        currentindex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(currentindex);
        SceneManager.LoadScene(currentindex);
    }
}
