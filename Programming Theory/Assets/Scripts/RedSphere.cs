using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSphere : Spheres //INHERITANCE
{
    void OnMouseDown()
    {
        SphereTrait(); //ABSTRACTION
    }

    public override void SphereTrait() //POLYMORPHISM
    {
        sphereText.text = MainManager.instance.username + " clicked the red sphere";
    }
}
