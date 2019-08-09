using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoadNextScene()
   {
        // Get count of number of scenes in Build Settings
        int scenes = SceneManager.sceneCountInBuildSettings;

        // Get index of currently active scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // condition to load next state. False when we are on the last scene
        if(currentSceneIndex!=scenes-1)
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
   }
}
