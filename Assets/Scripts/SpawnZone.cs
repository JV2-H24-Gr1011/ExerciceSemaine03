using UnityEngine;

public class SpawnZone : MonoBehaviour
{
[SerializeField]
private GameObject coffrePrefab;

[SerializeField] 
private Vector3 zoneSize;

[SerializeField] 
private float repeatTime ;
    
    void Start()
    {

        InvokeRepeating("Apparition", 2.0f, repeatTime);

    }
    
    
    void Update()
    {
        
    }

    private void OnDrawGizmos() {
        
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, zoneSize);
    }

    
    private void Apparition(){

        GameObject instantiated = Instantiate(coffrePrefab);

        instantiated.transform.position = new Vector3(

            Random.Range(transform.position.x - zoneSize.x / 2, transform.position.x + zoneSize.x / 2),
            Random.Range(transform.position.y - zoneSize.y / 2, transform.position.y + zoneSize.y / 2),
            Random.Range(transform.position.z - zoneSize.z / 2, transform.position.z + zoneSize.z / 2)
        );

    }



}
