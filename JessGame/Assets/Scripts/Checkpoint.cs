using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            Debug.Log("working scene");
            SceneManager.LoadScene("NextLevelScene");
        }
        //this seems to work just need to make it change scenes, not sure if that is working yet
    }
}
