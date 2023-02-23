using UnityEngine;
using System.Collections.Generic;

// Date updated: 2023-02-20
[CreateAssetMenu(fileName = "CharacterScriptableObject", menuName = "CharacterScriptableObject")]
public class CharacterScriptableObject : ScriptableObject
{
    [SerializeField] Sprite charImg;
    [SerializeField] string charName;
    [SerializeField] int charStrength;
    [SerializeField] float charSpeed;
    [SerializeField] string charDescription;
    public Sprite Img{
        get{
            return charImg;
        }
    }
    public string Name{
        get{
            return charName;
        }
    }
    public int Strength{
        get{
            return charStrength;
        }
    }
    public float Speed{
        get{
            return charSpeed;
        }
    }
    public string Description{
        get{
            return charDescription;
        }
    }
    

}
