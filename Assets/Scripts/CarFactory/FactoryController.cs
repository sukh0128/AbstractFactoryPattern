using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryController : MonoBehaviour
{
    public MonoBehaviour factoryComponent;
    public GameObject classicCarPrefab;
    public GameObject racingCarPrefab;
    private IAbstractCarFactory carFactory;
    public Transform spawnPoint;

    private bool isInside = false;

    private void Start()
    {
        //this line to add the MonoBehaviour class to the IAbstractCarFactory because it is an interface
        carFactory = factoryComponent as IAbstractCarFactory;

        if (factoryComponent is RedFactory redFactory)
        {
            redFactory.classicCarPrefab = classicCarPrefab;
            redFactory.racingCarPrefab = racingCarPrefab;
        }
        else if (factoryComponent is BlueFactory blueFactory)
        {
            blueFactory.classicCarPrefab = classicCarPrefab;
            blueFactory.racingCarPrefab = racingCarPrefab;
        }
        else if (factoryComponent is BlackFactory blackFactory)
        {
            blackFactory.classicCarPrefab = classicCarPrefab;
            blackFactory.racingCarPrefab = racingCarPrefab;
        }
    }


    private void Update()
    {
        if (isInside)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                ICarProduct classicCar = carFactory.CreateClassicCar(spawnPoint.position);
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                ICarProduct racingCar = carFactory.CreateRacingCar(spawnPoint.position);
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInside = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInside = false;
        }

    }
}
