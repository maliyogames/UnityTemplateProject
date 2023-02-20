using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Date updated: " + DateTime.Now.ToString("MM/dd/yyyy")


public class TestClass :MonoBehaviour
{
    public TextMeshProUGUI labelTxt;
    public string Label{
        get{
            return labelTxt.text;
        }
        set{
            labelTxt.text=value;
        }
    }
    
}