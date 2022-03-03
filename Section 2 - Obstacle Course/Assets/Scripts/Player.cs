using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] float xMoveSpeed = 1f;
    [SerializeField] float zMoveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float x_trans = Input.GetAxis("Horizontal") * xMoveSpeed * Time.deltaTime;
        float z_trans = Input.GetAxis("Vertical") * zMoveSpeed * Time.deltaTime;

        transform.Translate(x_trans, 0, z_trans);
    }

    
}
