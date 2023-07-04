using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Value : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    // Start is called before the first frame update
    string val;
    void Start()
    {
        val = GetComponentInChildren<TextMeshProUGUI>().text;
    }

    public void click()
    {
        inputField.text += val;
    }
}
