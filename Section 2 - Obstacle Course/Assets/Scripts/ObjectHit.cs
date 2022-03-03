using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // Debug.Log("Player overlap with the wall");

        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.cyan;
            gameObject.tag = "Hit";
            Debug.Log("Đổi tag thành hit");
        }
    }
}
