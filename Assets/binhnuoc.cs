using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binhnuoc : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void FixedUpdate()
    {
        float hr = Input.GetAxis("Horizontal");
        float vr = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(hr, 0.0f,vr);
        GetComponent<Rigidbody>().AddForce(move * speed * Time.deltaTime);
    }
}
