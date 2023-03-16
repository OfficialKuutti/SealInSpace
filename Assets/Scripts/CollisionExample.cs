using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This is used when gameobject need move to specific place in vector3(x,y,z) when collide with tagged "Obstacle" is happened!
public class CollisionExample : MonoBehaviour
{
    public GameObject retryButton;
    public GameObject explosion;
    public GameObject quitButton;
    public Animator cameraAnim;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            StartCoroutine(HitStop());

        }
       
       
    }
    public IEnumerator HitStop()
    {
        Time.timeScale = 0.0f;
        yield return new WaitForSecondsRealtime(0.0f);
        Time.timeScale = 1f;
        cameraAnim.SetTrigger("Shake");
        Instantiate(explosion, transform.position, transform.rotation);
        quitButton.SetActive(true);
        retryButton.SetActive(true);
        Destroy(gameObject);
    }

}
