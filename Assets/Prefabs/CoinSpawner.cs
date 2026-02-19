using UnityEngine;

namespace Prefabs
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject coinPrefab;
        [SerializeField] private int coinAmount = 10;
        [SerializeField] private BoxCollider groundCollider;

        void Start()
        {
            for (int i = 0; i < coinAmount; i++)
            {
                Vector3 startPos = RandomPointInBounds(groundCollider.bounds);
                Instantiate(coinPrefab, startPos, Quaternion.identity);
            }
        }

        public static Vector3 RandomPointInBounds(Bounds bounds)
        {
            return new Vector3(
                Random.Range(bounds.min.x, bounds.max.x),
                bounds.max.y,
                Random.Range(bounds.min.z, bounds.max.z)
            );
        }
    }
}


