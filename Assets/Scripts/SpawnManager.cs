using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnRoutine");
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Instantiate(_enemyPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
}
