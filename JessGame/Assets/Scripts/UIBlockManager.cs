using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class UIBlockManager : MonoBehaviour
{
    [SerializeField] private BlockSpawnerRedo blockManager;
    private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        blockManager = FindObjectOfType<BlockSpawnerRedo>();
    }

    private void Update()
    {
        text.text = "Block Limit: " + blockManager.blockLimit.ToString();
    }
}
