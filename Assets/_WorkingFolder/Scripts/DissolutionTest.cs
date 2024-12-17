using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolutionTest : MonoBehaviour
{
    public Material mat;

    public Transform m_targetObj;

    // Update is called once per frame
    void Update()
    {
        mat.SetVector("_targetpos", m_targetObj.position);
    }
}
