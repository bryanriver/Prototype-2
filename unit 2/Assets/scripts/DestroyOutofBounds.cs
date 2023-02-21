using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    private float topBoundary =30;
    private float lowerBound = -10;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBoundary) 
        {
            Destroy(gameObject);
        }  else if (transform.position.z < lowerBound) 
        {
            Debug.Log("Game Over!"); 
            Destroy(gameObject);
        }
    }
}
