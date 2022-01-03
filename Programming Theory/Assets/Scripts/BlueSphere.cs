using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSphere : Spheres
{
    void OnMouseDown()
    {
        SphereTrait();
    }

    public override void SphereTrait()
    {
        sphereText.text = MainManager.instance.username + " clicked the blue sphere";
    }
}
