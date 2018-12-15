using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImprovedTransformModifier : MonoBehaviour
{

    public TransformModifier[] listTargets;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   

        if(listTargets != null)
        foreach (TransformModifier _object in listTargets)
        {
            if(_object.target != null)
            {
                _object.target.transform.Translate(_object.translation * Time.deltaTime);
                _object.target.transform.Translate(_object.rotation * Time.deltaTime);
                _object.target.transform.Translate(_object.scale * Time.deltaTime);
            }

        }
    }


}