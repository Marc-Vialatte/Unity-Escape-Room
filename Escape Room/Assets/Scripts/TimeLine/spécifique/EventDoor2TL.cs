using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDoor2TL : MonoBehaviour, Interface_TL_Events
{
    public GameObject GO;
    private GameObject door;
    public GameObject door2;
    public GameObject character;
    public float DebutEventTL = 15;
    public bool Periodique = false;
    public float Periode = 0;
    public float DureeEventTL = 1;
    public float MaxDureeEventTL = 30;

    public void Awake()
    {
        door = GO;
    }

    public void stop_TL_Event()
    {
        Destroy(this);
    }

    public float getDuration_TL_Event()
    {
        if (!door) throw new NotImplementedException();
        return DureeEventTL;
        //return p_as.clip.length;
    }

    public float getStartTime_TL_Event()
    {
        return DebutEventTL;
    }
    public float getStopTime_TL_Event()
    {
        return DebutEventTL + MaxDureeEventTL;
    }


    public bool isPausable_TL_Event()
    {
        return false;
    }
    public bool isPerdiodic_TL_Event(out float period)
    {
        period = Periode;
        return Periodique;
    }

    public bool isRandomizable_TL_Event()
    {
        return false;// rien à faire ou pas prévu
    }


    public void pause_TL_Event()
    {
        return; // rien à faire ou pas prévu
    }

    public void randomize_TL_Event()
    {
        return; // rien à faire ou pas prévu
    }

    public void restart_TL_Event()
    {
        return; // rien à faire ou pas prévu
    }

    public void start_TL_Event()
    {
        if (!door) throw new NotImplementedException();

        if (door.GetComponent<Animator>().GetBool("character_nearby") == false)
        {
            if (character.GetComponent<Inventory>().getOpenCard() == false)
            {
                _MGR_ScenarioManager.Instance.EtapeSuivante();
                door.GetComponent<Open_door>().Opendoor();
                door2.GetComponent<Open_door>().Opendoor();
            }
            else
            {
                door.GetComponent<Open_door>().Opendoor();
                door2.GetComponent<Open_door>().Opendoor();
            }
        }
        return;
    }

    public void TL_ChronoArrete()
    {
        return; // rien à faire ou pas prévu
    }

    public void TL_ChronoDemarre()
    {
        return; // rien à faire ou pas prévu
    }

    public void TL_ChronoEnPause()
    {
        return; // rien à faire ou pas prévu
    }
    public void TL_ChronoReprise()
    {
        return; // rien à faire ou pas prévu
    }
}
