using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannerController : MonoBehaviour
{
    public float speed = 10;
    public float delay_destory_time = 5;
    private void Start()
    {
        Destory_Object();
    }
    void Update()
    {
        Vector3 vectorMesh = transform.localScale;
        float growing = this.speed * Time.deltaTime;
        transform.localScale = new Vector3(vectorMesh.x + growing, vectorMesh.y + growing, vectorMesh.z + growing);
    }
    private void Destory_Object()
    {
        Destroy(gameObject, delay_destory_time);
    }
}
