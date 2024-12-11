using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhMyGirl : MonoBehaviour
{
    
    public GameObject Classified;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
                
        transform.position += new Vector3(-0.02f,0,0);

    }
}
