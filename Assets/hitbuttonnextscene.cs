using UnityEngine;
using UnityEngine.SceneManagement;

public class hitbuttonnextscene : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("level 1");
    }
}
