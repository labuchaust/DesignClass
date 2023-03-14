using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawnerRedo : MonoBehaviour
{
    public GameObject blockPrefab;

    public int blockLimit = 10;
    private int blockCount = 0;


    [System.Serializable]
    private struct BlockData
    {
        public Vector2 spawnedLocation;
        public string blockType;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bool blockLimitIsNotReached = blockCount < blockLimit;
            if (blockLimitIsNotReached)
            {
                Vector3 mousePosition = Input.mousePosition;
                mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                mousePosition.z = 0;
                blockCount++;
                GameObject block = Instantiate(blockPrefab, mousePosition, Quaternion.identity);

                var data = new BlockData()
                {
                    spawnedLocation = block.transform.position,
                    blockType = "square"
                };
                TelemetryLogger.Log(this, "spawned a block", data);
            }
            //the limit does not work right now. But everything else does. Please fix it so that we can limit  the blocks spawned :)
        }


    }
}
