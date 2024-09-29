using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float posX, posY;
    public GameObject GoalObject;
    // Start is called before the first frame update
    void Start()
    {
        GoalObject.transform.position = Randomizer();
        transform.position = Randomizer();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.UpArrow))
            transform.position = new Vector3(transform.position.x, transform.position.y+1, transform.position.z);
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            transform.position = new Vector3(transform.position.x, transform.position.y-1, transform.position.z);
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            transform.position = new Vector3(transform.position.x-1, transform.position.y, transform.position.z);
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            transform.position = new Vector3(transform.position.x+1, transform.position.y, transform.position.z);

        GameWin();

    }

    Vector3 Randomizer()
    {
        posX = Random.Range(-2, 2);
        posY = Random.Range(-4, 4);
        return new Vector3(posX, posY, transform.position.z);
    }

    public void GameWin()
    {
        if (transform.position == GoalObject.transform.position)
        {
            Debug.Log("you won");
            Time.timeScale = 0;
        }
          
    }

}
