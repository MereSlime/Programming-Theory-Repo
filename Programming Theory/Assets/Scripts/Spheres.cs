using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spheres : MonoBehaviour
{
    public TextMeshProUGUI sphereText;

    public virtual void SphereTrait()
    {
        sphereText.text = MainManager.instance.username + " clicked the sphere";
    }


}
