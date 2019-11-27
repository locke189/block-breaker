using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Level : MonoBehaviour
{
    // events
    public UnityEvent onLevelWin;

    // state
    int blockCount;
    int blockDestroyed;

    private void Start()
    {
        blockCount = FindObjectsOfType(typeof(Block)).Length;
        blockDestroyed = 0;
        Debug.Log(blockCount);
    }

    public void CountDestroyedBlock() {
        blockDestroyed++;
        Debug.Log(blockDestroyed);
    }

    private void Update()
    {
        if (blockDestroyed == blockCount) {
            Debug.Log("level Complete");
            onLevelWin.Invoke();
        }
    }

}
