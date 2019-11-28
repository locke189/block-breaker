using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private void Awake()
    {
        int gameControllerInstances = FindObjectsOfType<GameController>().Length;

        if (gameControllerInstances > 1)
        {
            gameObject.SetActive(false); // Faster than Destroy
            Destroy(gameObject);
        }
        else {
            DontDestroyOnLoad(gameObject);
        }
    }
}
