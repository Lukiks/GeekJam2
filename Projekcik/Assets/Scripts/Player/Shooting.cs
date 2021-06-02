using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;
    public bool gun = false;
    public float bulletForce = 10f;
    public Rigidbody2D rb1;
    private float angle;
    private Vector2 mousePos;
    private float originOffset = 0.5f;

    void Start()
    {
        
    }

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Vector2 lookDir = mousePos - rb1.position;
        //angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        /*
        gameObject.GetComponent<Animator>().SetBool("gun", gun);
        if (gun)
        {
            if(Input.GetButtonDown("Fire1")&&player.GetComponent<PlayerSC>().energyCells > 0)
            {
                CheckRaycast(mousePos);
                Shoot();
                player.GetComponent<PlayerSC>().energyCells -= 1;
            }
        }
    }

    void Shoot()
    {
        Ray2D ray1 = new Ray2D(rb1.transform.position, mousePos);
        RaycastHit2D[] hits = Physics.RaycastAll(ray1, 30f);

        foreach (var hit in hits)
        {
            Debug.DrawLine(rb1.transform.position, hit.point, Color.blue, 1f);
            if (hit.transform.root != transform)
            {
                if(hit.transform.root.tag == "Enemy")
                {
                    Debug.Log("Enemy");
                }
            }
        }*/
    }

    private RaycastHit2D CheckRaycast(Vector2 direction)
    {
        float directionOriginOffset = originOffset * (direction.x > 0 ? 1 : -1);

        Vector2 startingPosition = new Vector2(transform.position.x + directionOriginOffset, transform.position.y);

        Debug.DrawRay(startingPosition, direction, Color.red);
        return Physics2D.Raycast(startingPosition, direction, 30f);
    }

    public void TakeGun()
    {
        gun = !gun;
    }
}
