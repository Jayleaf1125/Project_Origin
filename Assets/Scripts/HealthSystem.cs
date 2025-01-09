using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public float health;
    [SerializeField] private float max_health = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = max_health;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
