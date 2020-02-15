using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]public bool OpenCard = false;
    public int CodeCard;

    public void addOpenCard()
    {
        OpenCard = true;
    }
    public void addCodeCard()
    {
        CodeCard += 1;
    }
    public bool getOpenCard()
    {
        return OpenCard;
    }
    public int getCodeCard()
    {
        return CodeCard;
    }
}
