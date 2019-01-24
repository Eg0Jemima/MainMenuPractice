using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyEver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        //This is the way prevent duplicate generation of DontDestroyOnLoad objects without Singleton
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            //For more complicated app, you will need to identify object by name before destroying it
            Destroy(gameObject);
        }
    }
}
