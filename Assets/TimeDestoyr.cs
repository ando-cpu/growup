using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestoyr : MonoBehaviour
{
    public float DestroyTime = 2f;  
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
