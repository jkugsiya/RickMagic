using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasScript : MonoBehaviour
{
    GameObject canvas;
    public GameObject rickshaw;
    public GameObject canvas2;
    
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void show()
    {
        rickshaw.SetActive(true);
        canvas.SetActive(false);

        
        Invoke("showcanvas", 3.6f);
        /*canvas2.SetActive(true);*/
    }
    void showcanvas()
    {
        canvas2.SetActive(true);
    }
}
