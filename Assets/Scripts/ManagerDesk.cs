using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text;

public class ManagerDesk : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI PassWord;
    [SerializeField] GameManager gm;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            PassWord.gameObject.SetActive(true);
            PassWord.text = gm.PassCode;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            PassWord.gameObject.SetActive(false);
        }
    }
    
}
