using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSphere : Spheres //INHERITANCE
{
    void OnMouseDown()
    {
        SphereTrait();//ABSTRACTION
    }

    public override void SphereTrait()//POLYMORPHISM
    {
        sphereText.text = MainManager.instance.username + " clicked the blue sphere";
    }
}
