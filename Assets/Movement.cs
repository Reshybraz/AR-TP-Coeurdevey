using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public Transform traintomove;
    public Vector3 direction, resetposition;
    public float speed;
    public Slider s;
    public Toggle t;
    public AudioSource music;
    public bool AR;
    public GameObject associatedTarget;
    private Vector3 initialposition;
    private bool playmusic;
    // Start is called before the first frame update
    void Start()
    {
        initialposition = traintomove.position;
        s.value = speed;
        playmusic = true;
        t.isOn = traintomove.gameObject.activeSelf;
    }

    // Update is called once per frame
    void Update()
    {   
        speed = s.value;
        traintomove.position += direction * Time.deltaTime * speed;
        if (Mathf.Abs(traintomove.position.x) >= Mathf.Abs(resetposition.x) & Mathf.Abs(traintomove.position.y) >= Mathf.Abs(resetposition.y) & Mathf.Abs(traintomove.position.z) >= Mathf.Abs(resetposition.z)) { traintomove.position = initialposition; }
        if (speed== 0)
        {
            playmusic= false;
            music.Stop();
        }
        else
        {
            if (playmusic == false) {
                playmusic= true;
                music.Play();
            }
        }
    }
    public void ChangeActive()
    {
        if (AR)
        {
            associatedTarget.SetActive(!associatedTarget.activeSelf);
        }
        else
        {
            traintomove.gameObject.SetActive(!traintomove.gameObject.activeSelf);
        }
    }

}
