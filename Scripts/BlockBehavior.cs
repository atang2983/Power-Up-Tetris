using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehavior : MonoBehaviour
{
    private double oldFallSpeed;
    public static double fallSpeed = 0.5;
    public static double changedFallSpeed = fallSpeed;
    public static int maxWidth = 10;
    public static int maxHeight = 20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
          transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)){
          transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)){
          transform.Rotate(0, 0, 90);
        }
        if (Input.GetKeyDown(KeyCode.RightControl) || Input.GetKeyDown(KeyCode.Z)){
          transform.Rotate(0, 0, -90);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
          double maxFallSpeed = 0.2;
          if (fallSpeed >= maxFallSpeed){
            fallSpeed = fallSpeed - 0.1;
          }
        }

        if (Time.time - oldFallSpeed > fallSpeed){
          transform.position += new Vector3(0, -1, 0);
          oldFallSpeed = Time.time;
        }
    }

  //  bool falsePos{
      //foreach (Transform child in transform){
      //  int
    //  }
  //  }
}
