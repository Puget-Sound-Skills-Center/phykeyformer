using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class objectdrop : MonoBehaviour
{
    [SerializeField] private gamelogicmanager logic;
    private int currentobj;
    private int arraytogoto;
    public GameObject square;
    public GameObject circle;
    private followmouse mouse;
    private Quaternion norotation = Quaternion.identity;

    string[,] dropbylevel = {   {"c", ""}, //7
                                {"c", ""}, //8
                                {"c", "s"}, //9
                                {"c", "s"}, //10
                                {"c", "s"}, //11
                                {"c", "s"}, //12
                                {"c", "s"}, //13
                                {"c", "s"}, //14
                                {"c", "s"}, //15
                            };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentobj = 0;
        arraytogoto = SceneManager.GetActiveScene().buildIndex - 7;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(dropbylevel[arraytogoto, currentobj]);
        if (logic.dropobject() && dropbylevel[arraytogoto, currentobj] != "") 
        { 
            if (dropbylevel[arraytogoto, currentobj] == "c") { Object.Instantiate(circle, mouse.spawntransform.position, norotation); }
            else if (dropbylevel[arraytogoto, currentobj] == "s") { }
            else { Debug.Log("yo bro you messed something up inside the omega array in objectdrop.cs"); }
        }
    }
}
