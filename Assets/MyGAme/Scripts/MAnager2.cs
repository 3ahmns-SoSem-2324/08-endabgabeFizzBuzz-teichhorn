using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using System.Data;

public class MAnager2 : MonoBehaviour
{

    public Button genNum;
    public TMP_Text Number;
    public TMP_Text rightNumber;
    public TMP_Text wrongNumber;
    public TMP_Text infoTxt;
    int rNumber;
    public Image right;
    public Image wrong;
    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomNumber = Random.Range(0, 1001);
            string randomString = randomNumber.ToString();
            Number.text = randomString;
            rNumber = randomNumber;
            rightNumber.text = "";
            wrongNumber.text = "";
            infoTxt.text = " ";
            right.color = Color.white;
            wrong.color = Color.white;
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rightNumber.text = "";
            wrongNumber.text = "";
            
            if (rNumber % 3 == 0 && rNumber % 5 == 0)
            {
                rightNumber.text = "right";
                right.color = Color.green;
            }
            else
            { 
                wrongNumber.text = "wrong";
                right.color = Color.red;
                infoTxt.text = "Eine Zahl ist durch 3 + 5 teilbar wenn die Quersumme durch 3 teilbar ist und die letzte Zahl 0 oder 5 ist.";
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rightNumber.text = "";
            wrongNumber.text = "";
            
            if (rNumber % 3 == 0)
            {
                rightNumber.text = "right";
                right.color = Color.green;
            }
            else
            {
                wrongNumber.text = "wrong";
                right.color = Color.red;
                infoTxt.text = "Eine Zahl ist durch 3 teilbar, wenn ihre Quersumme, das heiﬂt die Summe ihrer Ziffern, durch 3 teilbar ist.";
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rightNumber.text = "";
            wrongNumber.text = "";
            
            if (rNumber % 5 == 0)
            {
                rightNumber.text = "right";
                right.color = Color.green;
            }
            else
            {
                wrongNumber.text = "wrong";
                right.color = Color.red;
                infoTxt.text = "Eine Zahl ist durch 5 teilbar, wenn die letzte Ziffer eine 0 oder 5 ist.";
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightNumber.text = "";
            wrongNumber.text = "";
            infoTxt.text = "";
            
            if (rNumber % 3 != 0 && rNumber % 5 != 0)
            {
                rightNumber.text = "right";
                right.color = Color.green;
            }
            else
            {
                wrongNumber.text = "wrong";
                right.color = Color.red;
            }
        }
    }
}