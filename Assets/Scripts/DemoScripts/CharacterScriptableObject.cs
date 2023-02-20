using UnityEngine;
using System.Collections.Generic;

// Date updated: " + DateTime.Now.ToString("MM/dd/yyyy")
[CreateAssetMenu(fileName = "CharacterScriptableObject", menuName = "CharacterScriptableObject")]
public class CharacterScriptableObject : ScriptableObject
{
    [SerializeField] Sprite charImg;
    [SerializeField] string charName;
    [SerializeField] int charStrength;
    [SerializeField] float charSpeed;
    [SerializeField] string charDescription;
    

}
