using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniqueMainCamera : MonoBehaviour
{

    static UniqueMainCamera _instance;



    void Awake()
    {

        if (_instance != null)
        {

            Destroy(gameObject);

        }
        else
        {

            _instance = this;

        }

    }

}
