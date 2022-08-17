using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Re : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x,-2.5f,3.5f), gameObject.transform.position.y, Mathf.Clamp(gameObject.transform.position.z, -0.8f,4.5f));
    }
}
