using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float HorizontalScreenLimit;
    public GameObject Player;
    float GasolinePrefabTimer = 4;
    public GameObject GasolinePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            GasolinePrefabTimer = GasolinePrefabTimer - Time.deltaTime;
        if (GasolinePrefabTimer < 0)
            {
                GameObject GasolinePrefabObject = Instantiate(GasolinePrefab);
                GasolinePrefabObject.transform.SetParent(transform);
                GasolinePrefabObject.transform.position = new Vector3(Random.Range(HorizontalScreenLimit, -HorizontalScreenLimit), Player.transform.position.y + 2, Player.transform.position.z);
                GasolinePrefabTimer = Random.Range(5, 7);
                Destroy(GasolinePrefabObject.gameObject, 12);
            }
        }
    }
}
