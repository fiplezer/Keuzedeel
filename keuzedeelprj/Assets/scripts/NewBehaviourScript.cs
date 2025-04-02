using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        var myObjects GameObject[];
        var startPos Vector3[];  
        var startRot Quaternion[];
    }


    function Reset()
    {

        startPos = new Vector3[myObjects.length];
        startRot = new Quaternion[myObjects.length];

        for (i = 0; i <= myObjects.length - 1; i++)
        {

            startPos _ = myObjects.transform.position;
        }
    }
  }
