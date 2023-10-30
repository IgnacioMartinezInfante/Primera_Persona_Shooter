using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;


public class controlenemigo : MonoBehaviour 
{ 
    private int hp;

    public controlenemigo enemigoPrefab;

    [SerializeField] public Transform Target;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private float findtargetrate;
    [SerializeField] private float initialdelay;

    private void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("jugador");
        if (player != null)
        {
            Target = player.transform;
        }
    }
    void Start() 
    { 
        hp = 25;
        agent = GetComponent<NavMeshAgent>();

        InvokeRepeating("findtarget", initialdelay, findtargetrate);
    } 
    public void recibirDaño() 
    { 
        hp = hp - 25; 
        if (hp <= 0) 
        { 
            this.desaparecer(); 
        } 
    } 
    private void desaparecer() 
    { 
        Destroy(gameObject); 
    }

    private void OnCollisionEnter(Collision collision) 
    { 
        if (collision.gameObject.CompareTag("bala")) 
        {
            recibirDaño();
        } 
    }

    public void findtarget()
    {
        agent.destination = Target.position;
    }
}
