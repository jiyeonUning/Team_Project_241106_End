using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAnim : MonoBehaviour
{
    [SerializeField] Animator animator;

    public void PlayHitAnimation()
    {
        if (animator == null)
            return;


        animator.SetBool("isHit", true);
    }

    public void DestroyTime(GameObject gameObject)
    {
        if (gameObject.name == "Player_Flame(Clone)")
        {
            Destroy(gameObject, 0.8f);
        }

        if (gameObject.name == "Player_Bullet(Clone)")
        {
            Destroy(gameObject);
        }

        if (gameObject.name == "Player_Heavy(Clone)")
        {
            Destroy(gameObject);
        }

        if (gameObject.name == "Player_Roket(Clone)")
        {
            Destroy(gameObject);
        }

        if (gameObject.name == "Player_Shotgun(Clone)")
        {
            Destroy(gameObject, 0.9f);
        }

        if (gameObject.name == "JetBullet(Clone)")
        {
            Destroy(gameObject, 0.5f);
        }

        if (gameObject.name == "JetBullet(Clone)1")
        {
            Destroy(gameObject, 0.9f);
        }

        if (gameObject.name == "JetBullet(Clone)2")
        {
            Destroy(gameObject, 0.9f);
        }
    }

}