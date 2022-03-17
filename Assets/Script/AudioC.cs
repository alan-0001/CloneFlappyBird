using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioC : MonoBehaviour
{

    public GameObject efeitoTok;
    public GameObject efeitoDingle;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("pipes"))
        {
            Instantiate(efeitoTok, new Vector3(this.gameObject.transform.position.x,this.gameObject.transform.position.y, this.gameObject.transform.position.z), Quaternion.identity);
        }

        if (outro.gameObject.CompareTag("ground"))
        {
            Instantiate(efeitoDingle, new Vector3(this.gameObject.transform.position.x,this.gameObject.transform.position.y, this.gameObject.transform.position.z), Quaternion.identity);
        }
    }

  
}
