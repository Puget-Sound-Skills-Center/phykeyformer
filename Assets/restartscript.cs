using UnityEngine;
using UnityEngine.SceneManagement;


public class restartscript : MonoBehaviour
{
    private string currentscene;
    currentscene = SceneManager.GetActiveScene();
    SceneManager.LoadScene(currentscene);
}
