using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
        private int score = 0;

    private void OnCollisionEnter(Collision other) 
    {
        // if(other.gameObject.tag == "Hit")
        //     return;

        Debug.Log("Có va chạm");
        if(other.gameObject.tag != "Hit")
        {
            score++;
            Debug.Log("Đã va chạm với một object, score hiện tại: " + score);
        }

        // if(gameObject.tag == "Player")
        // {
        //     other.gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
        //     other.gameObject.tag = "Hit";
        //     Debug.Log("Đổi tag thành hit");
        // }
        
    }
}
