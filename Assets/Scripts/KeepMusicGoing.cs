using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepMusicGoing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject.GetComponent<AudioSource>());

        //This is the way prevent duplicate generation of DontDestroyOnLoad objects without Singleton
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            //For more complicated app, you will need to identify object by name before destroying it
            Destroy(gameObject);
        }

        //This is how to do it with singleton
        //private static Player playerInstance;
        //void Awake()
        //{
        //    DontDestroyOnLoad(this);

        //    if (playerInstance == null)
        //    {
        //        playerInstance = this;
        //    }
        //    else
        //    {
        //        DestroyObject(gameObject);
        //    }
        //}
    }
}
