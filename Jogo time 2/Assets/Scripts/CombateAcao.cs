﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Nova Ação", menuName = "Ação")]
public class CombateAcao : ScriptableObject
{
    public enum tipoDano
    {
        Agressivo,
        Manipulador,
        Diplomatico,
        Neutro
    }

    //A: atributos de um ataque:
    [Header("Dados de uma ação:")]
    [Tooltip("Nomes que aparecerão no botão. Escolhidos aleatoriamente a cada turno")]
    //nome: o que sera mostrado no botao
    public string[] nome;

    [Tooltip("Multiplicador do atributo de dano de quem executa a ação, em %")]
    //dano: porcentagem, multiplicador sobre o atributo de ataque da unidade
    public float dano;

    [Tooltip("Quantidade carregada da barra de argumentos ao utilizar o ataque")]
    public int barraArgumento;

    [Tooltip("Tipo do dano causado.")]
    //tipo: para definir se alvo tem resistencias ou desvantagens
    public tipoDano tipo;
}
