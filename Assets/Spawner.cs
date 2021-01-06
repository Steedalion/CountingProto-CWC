using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject[] prefabs;
	public float zmin,zmax;
	[Range(0.5f,5f)] public float spawnInterval=1f;
	WaitForSeconds wait;
    // Start is called before the first frame update
    void Start()
    {
	    wait = new WaitForSeconds(spawnInterval);
	    StartCoroutine(SpawnOnInterval());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	void Spawn()
	{
		GameObject obj = Instantiate(prefabs[Random.Range(0, prefabs.Length)]);
		obj.transform.position = new Vector3(transform.position.x, transform.position.y, Random.Range(zmin, zmax));
	}
	
	IEnumerator SpawnOnInterval()
	{
		while(true)
		{
			Spawn();
			yield return wait;
		}
		
	}
}
