using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenSphere : Spheres
{
    void OnMouseDown()
    {
        SphereTrait();
    }

    // Update is called once per frame
    public override void SphereTrait()
    {
        sphereText.text = MainManager.instance.username + " clicked the green sphere";
    }
}
