using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Vector2 time_range_net;
    public Vector2 time_range_garbage;

    float _interval_for_net = 3f;
    float _interval_for_Garbage = 1f;

    float _time_net;
    float _time_garbage;
    public GameObject net;
    public GameObject garbage;
    public Transform SpawnPoint;
    private int TimebetweenNet=3;
    private int TimebetweenGarbage=3;

    // Update is called once per frame
    void Update()
    {
        _interval_for_net = Random.Range(time_range_net.x, time_range_net.y);
        _interval_for_Garbage = Random.Range(time_range_garbage.x, time_range_garbage.y);

        _time_net += Time.deltaTime;
        while (_time_net >= _interval_for_net)
        {
            spawnerNet();
            _time_net -= _interval_for_net;
        }
        _time_garbage += Time.deltaTime;
        while (_time_garbage >= _interval_for_Garbage)
        {
            spawnerGarbage();
            _time_garbage -= _interval_for_Garbage;
        }


    }

   
    
    void spawnerNet()
    {
        StartCoroutine(SpawnerNetDelay());
    }
    void spawnerGarbage()
    {
        StartCoroutine(SpawnerGarbageDelay());
    }

    public IEnumerator SpawnerNetDelay()
    { 
            yield return new WaitForSeconds(TimebetweenNet);
        var SpawnedNet = Instantiate(net, SpawnPoint.position, Quaternion.identity);
    

    }
    public IEnumerator SpawnerGarbageDelay()
    {
       
        yield return new WaitForSeconds(TimebetweenGarbage);
        var SpawnedGarbage = Instantiate(garbage, SpawnPoint.position, Quaternion.identity);

    }
}
