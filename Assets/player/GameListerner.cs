using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //namespace ini kita butuhkan agar dapat memanggil fungsi yang ada pada class SceneManagement

public class GameListerner : MonoBehaviour
{
    public GameObject EnemyReference;
    public GameObject[] Enemies;
    public byte EnemyCounter;
    public byte EnemyMax;
    public byte spawnedenemy;
    public byte[] spawncondition;
    public byte spawncounter;
    public bool timetospawn;

    

    // Start is called before the first frame update
    void Start()
    {
        Enemies = new GameObject[EnemyMax];
        for(int a=0;a<EnemyMax; a++)
        {
            if (EnemyCounter < EnemyMax)
            {
                Enemies[EnemyCounter] = Instantiate(EnemyReference, EnemyReference.transform.position, Quaternion.identity);
                Enemies[EnemyCounter].SetActive(false);
                EnemyCounter++;
            }
        }
        timetospawn = true;
    }

    // Update is called once per frame
    void Update()
    {

        spawn();

    }

    byte enemydead()
    {
        byte total = 0;
        for (int a = 0; a < EnemyMax; a++)
        {
            if(Enemies[a].name == "death")
            { total++; }
            
        }
        Debug.Log(total);
        return total;
    }

    void spawn()
    {
        if(spawnedenemy < EnemyMax)
        {
            if(timetospawn && spawnedenemy < spawncondition[spawncounter])
            {
                for (int a = 0; a < spawncondition[spawncounter]; a++)
                {
                    Enemies[spawnedenemy].SetActive(true);
                    spawnedenemy++;
                }
                timetospawn = false;
            }
            else
            {
                if (enemydead() >= spawncondition[spawncounter])
                {
                    spawncounter+=1;
                    timetospawn = true;
                }
            }

        }
        
    }
    
}
