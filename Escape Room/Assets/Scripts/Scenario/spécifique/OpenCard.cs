using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCard : INTERACTION_CLICK_AND_PICK
{
    public GameObject character;

    // Start is called before the first frame update
    override public void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    public override void Object_Picked()
    {
        character.GetComponent<Inventory>().addOpenCard();
        base.Declencher_Etape_Suivante_Du_Scenario();

        Destroy(this.gameObject);
    }
}
