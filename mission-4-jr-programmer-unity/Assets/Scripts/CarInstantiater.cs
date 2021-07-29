using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInstantiater : MonoBehaviour
{
    void Start()
    {
        if(SaveManager.instance.carSelected != null)
        {
            GameObject carToInstantiate = SaveManager.instance.carSelected;
            Instantiate(carToInstantiate, carToInstantiate.transform.position, carToInstantiate.transform.rotation);
        }
    }
}
