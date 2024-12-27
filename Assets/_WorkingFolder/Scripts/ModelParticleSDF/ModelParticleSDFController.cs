using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ModelParticleSDFController : MonoBehaviour
{
    public VisualEffect VisualEffect;
    public List<Texture3D> BakedSDFTexture3D = new List<Texture3D>(); 

    private int currentSDFIndex = 0; 
    private int SDFCount;

    void Start()
    {
        SDFCount = BakedSDFTexture3D.Count;

        if (SDFCount > 0)
        {
            VisualEffect.SetTexture("SDF", BakedSDFTexture3D[currentSDFIndex]);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentSDFIndex--;
            if (currentSDFIndex < 0)
            {
                currentSDFIndex = SDFCount - 1; 
            }
            UpdateVisualEffectTexture();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentSDFIndex++;
            if (currentSDFIndex >= SDFCount)
            {
                currentSDFIndex = 0; 
            }
            UpdateVisualEffectTexture();
        }
    }

    private void UpdateVisualEffectTexture()
    {
        if (SDFCount > 0)
        {
            VisualEffect.SetTexture("SDF", BakedSDFTexture3D[currentSDFIndex]);
            Debug.Log($"Texture switched to index: {currentSDFIndex}");
        }
    }
}