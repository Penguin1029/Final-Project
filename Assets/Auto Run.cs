using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoRun : MonoBehaviour
{
    public float speed = 0.5f;
    public string nextlevel = "Lvl_2";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        switch (collision.tag)

        {
            case "Death":

                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;


                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;


                }
        }
    }
}
