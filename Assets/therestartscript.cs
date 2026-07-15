using UnityEngine;
using UnityEngine.SceneManagement;
public class therestartscript : MonoBehaviour
{
    private string currentscenename;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentscenename = SceneManager.GetActiveScene().name;
    }
    public void reloadscene() 
    {
        SceneManager.LoadScene(currentscenename);
    }
}
