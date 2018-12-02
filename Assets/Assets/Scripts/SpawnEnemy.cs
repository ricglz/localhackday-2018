using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

    public GameObject prefabEnemy;
    public float segundo = 1f;

    private float RotateSpeed = 4f;
    private float Radius = 10f;
 
    private Vector2 _centre;
    private float _angle;

    private int LimitEnemies = 8;
    public static int CountEnemy;

    // Update is called once per frame
    void Start()
    {
        CountEnemy = 0;
        _centre = transform.position;
    }

    void Update () {
        _angle += RotateSpeed * Time.deltaTime;
 
        var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
        transform.position = _centre + offset;

        if (CountEnemy < LimitEnemies) {
            segundo -= Time.deltaTime;
            if (segundo < 0) {
                Spawn();
                segundo = 1f;
            }
        }
    }

    public void Spawn()
    {
        Instantiate(prefabEnemy, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        CountEnemy++;
    }
}
