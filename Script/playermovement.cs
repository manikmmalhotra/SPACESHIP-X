using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playermovement : MonoBehaviour
{
    [SerializeField] float movespeed = 0f;
    [SerializeField] GameObject cam;
    [SerializeField] TrackHandler th;

    internal static bool left = false;
    internal static bool right = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (left)
        {
            transform.Translate(Vector3.left * Time.deltaTime * movespeed);
        }
        else if (right)
        {
            transform.Translate(Vector3.right * Time.deltaTime * movespeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "obstacle")
        {
            cam.transform.parent = null;
            th.enabled = false;
            gameObject.SetActive(false);
            Invoke("GameOver", 1.5f);
        }
        else if (other.gameObject.tag == "border")
        {
            cam.transform.parent = null;
            th.enabled = false;
            gameObject.SetActive(false);
            Invoke("GameOver", 1.5f);
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene(2);
    }


}
