using UnityEngine;

public class SpawnOnPositions : MonoBehaviour
{

[SerializeField] 
private GameObject coffrePrefab;

[SerializeField]
private Transform[] spawnPoints;

[SerializeField] 
private float repeatTime ;


    void Start()
    {
        InvokeRepeating("Apparaitre", 2.0f, repeatTime);
    }


    void Update()
    {
        
    }


    private void Apparaitre(){

        Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

        GameObject instantiated = Instantiate(coffrePrefab);
        instantiated.transform.position = randomPoint.position;

    }
}
