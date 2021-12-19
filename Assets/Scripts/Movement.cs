using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float fart = 10.0f;
    private bool MoveUp;
    private bool MoveDown;
    private bool MoveRight;
    private bool MoveLeft;

    void Update()
    {

        // Movement
        if (MoveUp == true){
            transform.Translate(Vector3.forward * Time.deltaTime * fart);
        }
        if (MoveDown == true){
            transform.Translate(Vector3.back * Time.deltaTime * fart);
        }
        if (MoveRight == true){
            transform.Translate(Vector3.right * Time.deltaTime * fart);
        }
        if (MoveLeft == true){
            transform.Translate(Vector3.left * Time.deltaTime * fart);
        }

        //Keybinds
        if (Input.GetKeyDown("w")){
            MoveUp = true;
        }
        else if (Input.GetKeyUp("w")){
            MoveUp = false;
        }
        if (Input.GetKeyDown("s")){
            MoveDown = true;
        }
        else if (Input.GetKeyUp("s")){
            MoveDown = false;
        }
        if (Input.GetKeyDown("d")){
            MoveRight = true;
        }
        else if (Input.GetKeyUp("d")){
            MoveRight = false;
        }
        if (Input.GetKeyDown("a")){
            MoveLeft = true;
        }
        else if (Input.GetKeyUp("a")){
            MoveLeft = false;
        }
    }
}
