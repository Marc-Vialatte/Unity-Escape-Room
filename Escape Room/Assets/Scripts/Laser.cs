using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        _MGR_SceneManager.Instance.FinDePartie(_MGR_SceneManager.FIN_DE_PARTIE.PERDU_CHRONO);

    }
}
