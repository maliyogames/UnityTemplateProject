using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Date updated: 2023-02-20


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
