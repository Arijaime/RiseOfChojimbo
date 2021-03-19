using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeController : MonoBehaviour
{
    public GameObject cam;
    public GameObject camPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // movimiento de personaje
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 0.1f));
        }
        else
        {    
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector3(0, 0, -0.1f));
            }
        }
        
        // movimiento de la camara del personaje personaje
        if (Input.GetKey(KeyCode.D))
        {
            camPos.transform.SetParent(null);
            transform.Rotate(new Vector3(0,5.0f,0));
            camPos.transform.SetParent(transform);
        }
        else
        {    
            if (Input.GetKey(KeyCode.A))
            {
                camPos.transform.SetParent(null);
                transform.Rotate(new Vector3(0,-5.0f,0));
                camPos.transform.SetParent(transform);
                
            }
        }
        
        cam.transform.position=Vector3.Lerp(cam.transform.position,camPos.transform.position,0.1f);
    }
}
