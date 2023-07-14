using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerationController : MonoBehaviour
{
    //Variables Publicas
    [Header("Mutation")]
    public int mutationValue;

    [Header("Body Parts")]
    public GameObject[] shapes;

    [Header("Parents & Sons")]
    public GameObject[] parentsGameobject;
    public GameObject[] sonsGameobjects;
    public GameObject perfectBeing;

    [Header("UI Elements")]
    public Text generationText;
    public GameObject parentsText;
    public GameObject perfectText;
    public GameObject restartButton;

    //Variables Privadas
    private bool isPerfectBeing = false;
    private int generation = 0;
    private GameObject[,] bodyParts = new GameObject[4, 4];

    private void Start()
    {
        int shape = 0;

        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                bodyParts[i, j] = shapes[shape];
                shape++;
            }
        }
    }
}
