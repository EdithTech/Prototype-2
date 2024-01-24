using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Game object

    [SerializeField] GameObject _foodPrefab;
    //private variable
    [SerializeField] float _speed = 10f;
    float _xRange = 14;
    float _yRange = 14;

    //offsets
    Vector3 _foodOffset = new Vector3(0, 0, 1f);

    void Update()
    {
        float _horInput = Input.GetAxis("Horizontal");
        float _verInput = Input.GetAxis("Vertical");

        if(transform.position.x < -_xRange){
            transform.position = new Vector3(-_xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x > _xRange){
            transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.z < 0){
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }

        if(transform.position.z > 14){
            transform.position = new Vector3(transform.position.x, transform.position.y, 14);       
        }



        transform.Translate(new Vector3(_speed * Time.deltaTime * _horInput, 0, _speed * Time.deltaTime * _verInput));

        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(_foodPrefab, transform.position + _foodOffset, Quaternion.identity);
        }
    }
}
