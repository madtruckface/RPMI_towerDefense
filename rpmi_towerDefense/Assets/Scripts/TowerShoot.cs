using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour {
    [Tooltip("Referencia al prefab de la bala")]
    public GameObject bulletPrefab;

    [Tooltip("Referencia al enemigo que voy a disparar")]
    public GameObject enemy;

    void Update() {

        // Instancia una bala cada vez que el jugador pulsa el espacio
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject bala = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bala.GetComponent<BulletMovement>().enemy = enemy;
        }
    }
}
