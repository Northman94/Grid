using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GridGenerator : MonoBehaviour
{

    [SerializeField]
    private GameObject tilePrefab;


    private int tilesInARow = 10;
    private int numberOfTiles = 100;
    private float distanceBetweenTiles = 1.0f; // .1f = beautiful explosion




    private void Start()//
    {
        CreateLines();

        CreateCells();
    }

    #region Grid
    private float x = -1.5f;
    private float z = 10.85f;
    
    public void CreateLines()
    {
        //Vertical
        //start 0/7/22
        //end 0/7/13
        
        for (int i = 0; i < 11; i++)
        {
            x += 1.0f;
            
            Debug.DrawLine(new Vector3(x, 0.3f, 11.9f), new Vector3(x, 0.3f, 21.8f), Color.red, Mathf.Infinity); // Math.infinity = время отображения
        }
        
        // Horizontal
        //x 0-10
        // z 12-22
        
        for (int j = 0; j < 11; j++)
        {
            z += 1.0f;
            Debug.DrawLine(new Vector3(-0.5f, 0.2f, z), new Vector3(9.5f, 0.2f, z), Color.red, Mathf.Infinity);
        }
    }
    #endregion



    #region Cells
    public void CreateCells()
    {
        float xOffset = 0.0f;
        float zOffset = 0.0f;

        int tilesCreated;

        for (tilesCreated = 0; tilesCreated < numberOfTiles; tilesCreated++)
        {
            xOffset += distanceBetweenTiles;

            if (tilesCreated % tilesInARow == 0)
            {
                zOffset += distanceBetweenTiles;
                xOffset = 0.0f;
            }
            //Creating Panels
            Instantiate(tilePrefab, new Vector3(transform.position.x + xOffset, 0, transform.position.z + zOffset), transform.rotation);
        }
    }
    #endregion






}