using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

int Xv=0;
int Yv=0;
public int Pl;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Pl == 1){
            if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Yv = Yv + 1;
            SetPosition();
        } else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Yv = Yv - 1;
            SetPosition();
        } else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Xv = Xv - 1;
            SetPosition();
        } else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Xv = Xv + 1;
            SetPosition();
        }} else if (Pl == 2)
        {
            if(Input.GetKeyDown(KeyCode.W))
        {
            Yv = Yv + 1;
            SetPosition();
        } else if(Input.GetKeyDown(KeyCode.S))
        {
            Yv = Yv - 1;
            SetPosition();
        } else if(Input.GetKeyDown(KeyCode.A))
        {
            Xv = Xv - 1;
            SetPosition();
        } else if (Input.GetKeyDown(KeyCode.D))
        {
            Xv = Xv + 1;
            SetPosition();
        }


    }}

    private void SetPosition()
    {
        transform.position = new Vector3(transform.position.x + Xv, transform.position.y + Yv, transform.position.z);
    }
}
