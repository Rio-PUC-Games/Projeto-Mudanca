﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaDialogos : MonoBehaviour
{
    private static ListaDialogos _instance;
    public static ListaDialogos Instance { get { return _instance; } }

    public List<DialogueBlock> Listadedialogos = new List<DialogueBlock>();
   

    // Start is called before the first frame update
    private void Awake()
    {
        {
            if (_instance != null && _instance != this)
            {
                Destroy(this.gameObject);
            }
            else
            {
                _instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
           
        }

    }

}
