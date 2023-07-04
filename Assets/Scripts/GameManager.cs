using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int passwordLength = 8;
    public string PassCode { get; private set; }=null;

    private void Start()
    {
        PassCode = GeneratePassword();
    }
    public string GeneratePassword()
    {
        string password = "";
        string possibleChars = "1234567890";//abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()

        for (int i = 0; i < passwordLength; i++)
        {
            int randomIndex = Random.Range(0, possibleChars.Length);
            password += possibleChars[randomIndex];
        }

        return password;
    }

}
