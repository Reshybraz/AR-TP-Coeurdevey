using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform traintomove;
    public Vector3 direction, resetposition;
    public float speed;
    private Vector3 initialposition;
    // Start is called before the first frame update
    void Start()
    {
        initialposition = traintomove.position;
    }

    // Update is called once per frame
    void Update()
    {
        traintomove.position += direction * Time.deltaTime * speed;
        if (Mathf.Abs(traintomove.position.x) >= Mathf.Abs(resetposition.x) & Mathf.Abs(traintomove.position.y) >= Mathf.Abs(resetposition.y) & Mathf.Abs(traintomove.position.z) >= Mathf.Abs(resetposition.z)) { traintomove.position = initialposition; }
    }
}
