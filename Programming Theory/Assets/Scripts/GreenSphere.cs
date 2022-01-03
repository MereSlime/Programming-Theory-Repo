using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenSphere : Spheres //INHERITANCE
{
    void OnMouseDown()
    {
        SphereTrait();//ABSTRACTION
    }

    // Update is called once per frame
    public override void SphereTrait()//POLYMORPHISM
    {
        sphereText.text = MainManager.instance.username + " clicked the green sphere";
    }
}
