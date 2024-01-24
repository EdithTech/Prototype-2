using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] float _speed = 20;

    void Update()
    {   
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        if(transform.position.z > 30){
            Destroy(this.gameObject);
        }else if(transform.position.z < -10){
            Destroy(this.gameObject);
            Debug.Log("Game Over!");
        }else if(transform.position.x > 40){
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other){
        if(other.transform.tag == "Animal"){
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

}
