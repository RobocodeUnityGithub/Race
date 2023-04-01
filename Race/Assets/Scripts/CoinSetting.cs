using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSetting : MonoBehaviour
{
    [SerializeField] private int price;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private GameObject coinFx;
    private MeshRenderer mesh;
    private BoxCollider coinCollider;
    private Rigidbody rb;

    private void Awake()
    {
        coinCollider = GetComponent<BoxCollider>();
        mesh = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.angularVelocity = new Vector3(0f, rotateSpeed, 0f);
    }
    public int GetPrice()
    {
        return price;
    }
    public void PickUp()
    {
        mesh.enabled = false;
        coinCollider.enabled = false;
        int randomTime = Random.Range(5, 8);
        //Instantiate(coinFx, transform.position, Quaternion.identity);
        Invoke("Respawn", randomTime);
    }

    private void Respawn()
    {
        mesh.enabled = true;
        coinCollider.enabled = true;
    }

}
