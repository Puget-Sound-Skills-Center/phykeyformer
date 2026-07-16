using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class objectdrop : MonoBehaviour
{
    [SerializeField] private gamelogicmanager logic;
    public int currentobj;
    public int arraytogoto;
    public GameObject square;
    public GameObject circle;
    private followmouse mouse;
    string[,] dropbylevel = {   {"s", "", "", "", ""}, //7
                                {"c", "", "", "", ""}, //8
                                {"s", "", "", "", ""}, //9
                                {"c", "", "", "", ""}, //10
                                {"s", "c", "", "", ""}, //11
                                {"c", "c", "", "", ""}, //12
                                {"c", "s", "", "", ""}, //13
                                {"c", "s", "s", "", ""}, //14
                            };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentobj = 0;
        arraytogoto = SceneManager.GetActiveScene().buildIndex - 8;
        mouse = GetComponent<followmouse>();
    }
    void Update()
    {
        Debug.Log(dropbylevel[arraytogoto, 0]);
        if ((Mouse.current.leftButton.wasPressedThisFrame) && (dropbylevel[arraytogoto, currentobj] != ""))
        {
            Debug.Log("hi");
            if (dropbylevel[arraytogoto, currentobj] == "c") { Object.Instantiate(circle, mouse.spawntransform.position, Quaternion.identity); }
            else if (dropbylevel[arraytogoto, currentobj] == "s") { Object.Instantiate(square, mouse.spawntransform.position, Quaternion.identity); } //these lowk dont work i think
            else { Debug.Log("yo bro you messed something up inside the omega array in objectdrop.cs"); }
            currentobj += 1;
        }
    }
}
