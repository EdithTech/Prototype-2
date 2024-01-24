using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    float _hold = -1;
    float _delay = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if(_hold > 0){
            _hold -= Time.deltaTime;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if(_hold < 0){
                _hold = _delay;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }

        }


    }
}
