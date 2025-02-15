using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    string String = "Hello";
    int yippe = 0;

    // Start is called before the first frame update
    void Start()
    { Debug.Log("Hello World");
        string String2 = "World";
        Debug.Log(String + String2);
     
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(yippe);
        yippe++;
        

    }
}
