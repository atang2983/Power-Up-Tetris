using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UserInput : MonoBehaviour
{
  public Text speedText;
  public int currentNum;
  public double newFallSpeed = BlockBehavior.fallSpeed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void incNum(){
      currentNum++;
      newFallSpeed -= 0.1;
      if (currentNum > 10){
        currentNum = 10;
        newFallSpeed = 0.1;
      }
      setText();
    }
    public void decNum(){
      currentNum--;
      newFallSpeed += 0.1;
      if (currentNum < 1){
        currentNum = 1;
        newFallSpeed = 1.0;
      }
      setText();
    }

    public void setText(){
      BlockBehavior.fallSpeed = newFallSpeed;
      speedText.text = currentNum.ToString();
    }
}
