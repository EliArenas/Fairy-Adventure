using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Mirror;

public class TableTopManager : NetworkBehaviour
{
    public Dice dice;

    [SerializeField] Button botonCambioEscena;
    [SerializeField] Button lanzaDado;

    [ServerCallback]
    private void Start()
    {
        botonCambioEscena.onClick.AddListener(ChangeScene);
        lanzaDado.onClick.AddListener(dice.ThrowDice);
    }

    [Server]
    public void ChangeScene()
    {
        NetworkManager.singleton.ServerChangeScene("ThirdScene");
    }
}
