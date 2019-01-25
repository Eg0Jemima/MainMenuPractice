using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject player;

    private void Awake()
    {
        //Ensure the game has been running in order to skip spacebar hint on return to scene 0
        if (Time.realtimeSinceStartup > 10)
        {
            player.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !player.activeInHierarchy || Input.touchCount > 0 && !player.activeInHierarchy)
        {
            player.SetActive(true);
        }
    }
}
