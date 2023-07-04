using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckPassCode : MonoBehaviour
{
    [SerializeField] GameObject Keypad;
    [SerializeField] TMP_InputField inputField;
    [SerializeField] bool test;
    [SerializeField] GameManager gm;
    [SerializeField] GameObject WrongPasscode; 
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Keypad.SetActive(true);
            test = true;
            Invoke(nameof(ActivateIF), 1f);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Keypad.SetActive(false);
            test = false;
        }
    }
   void ActivateIF()
   {
        inputField.ActivateInputField();
   }
    public void PassCheck()
    {
        if (test)
        {
            if (inputField.text.Equals(gm.PassCode))
            {
                GetComponent<BoxCollider>().isTrigger = true;
                Keypad.SetActive(false);
            }
            else
            {
                WrongPasscode.SetActive(true);
                Invoke(nameof(fal), 2f);
            }
        }
    }

    void fal()
    {
        WrongPasscode.SetActive(false);
    }

    public void Clear()
    {
        inputField.text = "";
    }

}
