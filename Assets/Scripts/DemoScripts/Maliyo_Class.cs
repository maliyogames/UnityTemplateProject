using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Date updated: 2023-02-27
public class Maliyo_Class :MonoBehaviour
{
    public int itemCount=0;
    [SerializeField]TestClass itemPrefab;
    [SerializeField]RectTransform itemContainer;
    public List<TestClass> myPrefabs=new List<TestClass>();

    void Start()
    {
        for(int i = 0; i<itemCount;i++)
        {
            var label = string.Format("Item {0}",i);
            CreateNewListItem(label);
        }
    }
    public void CreateNewListItem(string label)
    {
        var newItem = Instantiate(itemPrefab);
        newItem.transform.SetParent(
            itemContainer,
            worldPositionStays:false
        );
        newItem.Label = label;
    }
    void Update()
    {
        //Add your code
    }
}
