using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
// Date updated: " + DateTime.Now.ToString("MM/dd/yyyy")
public class CharacterManager :MonoBehaviour
{
    public List<CharacterScriptableObject> charObjects;
    public TextMeshProUGUI charDescription;
    public TextMeshProUGUI charName;
    public TextMeshProUGUI charSpeed;
    public TextMeshProUGUI charStrength;
    public Image charImg;
    public int charIndex;
    
    public void NextCharacter()
    {
        if (charIndex < charObjects.Count - 1)
        {
            charIndex++;
            
            
        }
    }
    public void PreviousCharacter()
    {
        if (charIndex > 0)
        {
            charIndex--;
            }
    }
}