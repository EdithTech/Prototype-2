using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] GameObject[] _animals;
    [SerializeField] float _delay = 2f;

    float _xRange = 14f;
    // float _YRange = 14f;
    void Start(){
        StartCoroutine(animalSpawn());
        StartCoroutine(animalSpawnSide());

    }

    void Update(){

    }
    IEnumerator animalSpawn(){

        while(true){

            float _ranTime = Random.Range(3f, 5f);
            int _ranAnimal = Random.Range(0, _animals.Length);
            float _ranXRange = Random.Range(-_xRange, _xRange);

            Instantiate(_animals[_ranAnimal], new Vector3(_ranXRange, 0f, 20f), _animals[_ranAnimal].transform.rotation);
            
            yield return new WaitForSeconds(_ranTime);
        }
    }
    IEnumerator animalSpawnSide(){

        while(true){

            float _ranTime = Random.Range(0, 4f);
            int _ranAnimal = Random.Range(0, _animals.Length);
            float _ranZRange1 = Random.Range(3f, 14f);
            float _ranZRange2 = Random.Range(3f, 14f);

            Instantiate(_animals[_ranAnimal], new Vector3(-20, 0f, _ranZRange1), Quaternion.Euler(0f, 90f, 0f));
            yield return new WaitForSeconds(_ranTime);

            Instantiate(_animals[_ranAnimal], new Vector3(20, 0f, _ranZRange2), Quaternion.Euler(0f, 270f, 0f));
            yield return new WaitForSeconds(_ranTime);
        }
    }
}
