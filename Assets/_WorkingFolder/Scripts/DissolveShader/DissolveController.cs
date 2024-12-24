using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveController : MonoBehaviour
{
    public Material dissolveMaterial;  // Assign the material using the shader
    [Range(0, 1)] public float dissolveAmount = 0f; // 0 = no dissolve, 1 = full dissolve

    void Update()
    {
        // Update the dissolve parameter in the material
        dissolveMaterial.SetFloat("_DissolveFloatTime", dissolveAmount);
    }
}
