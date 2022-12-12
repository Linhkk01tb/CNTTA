using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cua : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float goc = 3;
        
        if (goc<70 && goc>0)
        transform.Rotate(0,0, goc*0.1f);
    }
}