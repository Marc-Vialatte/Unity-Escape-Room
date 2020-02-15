using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseOpenCard : INTERACTION_CLICK_AND_PICK
{
    public GameObject character;
    public GameObject door;

    override public void Start()
    {
        base.Start();
    }
    public override void Object_Picked()
    {
        if (character.GetComponent<Inventory>().getOpenCard() == true)
        {
            door.GetComponent<Open_door>().Opendoor();
        }
    }
}
