using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_generator : INTERACTION_CLICK_AND_PICK
{
    public Material mat1;
    public Material mat2;
    Material[] mats;

    // Start is called before the first frame update
    override public void Start()
    {
        base.Start();
        mats = GetComponent<MeshRenderer>().materials;
    }

    // Update is called once per frame
    public override void Object_Picked()
    {
        mats[0] = mat1;
        mats[1] = mat2;
        GetComponent<MeshRenderer>().materials = mats;
        base.Declencher_Etape_Suivante_Du_Scenario();
    }
}