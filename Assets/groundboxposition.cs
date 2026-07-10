using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class groundboxposition : MonoBehaviour
{//playermovescript.playerposition();
    private playermovescript playermove;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = GameObject.Find("circleposition").transform.position; // dude it was literally this simple :sob:
    }
}
