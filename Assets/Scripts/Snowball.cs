using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Snowball : MonoBehaviour {
    
    private Rigidbody _rigidbody;

    private void Awake() {
        _rigidbody=GetComponent<Rigidbody>();
        Destroy(this.gameObject,5);
    }

    public void Fire(float velocity){
        _rigidbody.AddForce(transform.forward*velocity);
    }
    private void OnTriggerEnter(Collider c) {
        if(c.CompareTag("Enemy")){
            Health health= c.GetComponent<Health>();
            health.damage(1);
        }

    }
}