using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    [SerializeField] private BlockSpawnerRedo blockLimitScript;
    private int blockLimit;

    private void Start()
    {
        blockLimit = blockLimitScript.blockLimit;
    }

    private void Update()
    {
        // Check if the player has run out of blocks
        if (blockLimit <= 0)
        {
            Reset();
        }
    }
    
    public void Reset()
    {
        // Reload the current scene to reset the level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RemoveBlock()
    {
        // Decrement the block limit when a block is removed
        blockLimit--;
        blockLimitScript.blockLimit = blockLimit;
    }
}
