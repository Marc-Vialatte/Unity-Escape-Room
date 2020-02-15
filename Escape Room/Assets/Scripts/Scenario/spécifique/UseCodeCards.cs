using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseCodeCards : INTERACTION_CLICK_AND_PICK
{
    public GameObject character;
    public GameObject door;

    override public void Start()
    {
        base.Start();
    }
    public override void Object_Picked()
    {
        if (character.GetComponent<Inventory>().getCodeCard() >= 4)
        {
            door.GetComponent<Open_door>().Opendoor();
            base.Declencher_Etape_Suivante_Du_Scenario();
        }
    }
}
