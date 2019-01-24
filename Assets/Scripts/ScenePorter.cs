using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePorter : MonoBehaviour
{
    int numberOfScenes;

    private void Start()
    {
        numberOfScenes = SceneManager.sceneCountInBuildSettings;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Particle System")
        {
            Scene currentScene = SceneManager.GetActiveScene();

            //Loop through all scenes and if you get to the last one in build settings, restart to the first scene
            if(currentScene.buildIndex < numberOfScenes - 1) SceneManager.LoadScene(currentScene.buildIndex + 1, LoadSceneMode.Single);
            else SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
}
