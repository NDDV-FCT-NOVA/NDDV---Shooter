using UnityEngine;

namespace PlayerSpace
{
    public class PlayerShootingController : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;
        [SerializeField] private GameObject prefab;
        
        public void Shoot()
        {
            Instantiate(prefab, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity =
                Vector2.up * speed;
        }
    }
}