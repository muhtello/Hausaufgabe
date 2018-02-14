using UnityEngine;
using UnityEngine.SceneManagement;

public class deadPlayer : MonoBehaviour {
    public bool fromstart;
    public Transform startOver;
	// Use this for initialization
	void Start () {
        fromstart = false;
    }
	
	// Update is called once per frame
	void Update () {
        
       if (fromstart)
        {
            transform.position = startOver.transform.position;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            fromstart = true;
        }
        else
        {
            fromstart = false;
        }
    }
}
