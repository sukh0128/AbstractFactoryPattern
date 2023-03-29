using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFactory : MonoBehaviour, IAbstractCarFactory
{
    public GameObject classicCarPrefab;
    public GameObject racingCarPrefab;

    public ICarProduct CreateClassicCar(Vector3 spawnPosition)
    {
        GameObject carObject = GameObject.Instantiate(classicCarPrefab, spawnPosition, Quaternion.identity);
        ClassicCarProduct car = carObject.GetComponent<ClassicCarProduct>();
        car.SetColor(Color.blue);
        return car;
    }

    public ICarProduct CreateRacingCar(Vector3 spawnPosition)
    {
        GameObject carObject = GameObject.Instantiate(racingCarPrefab, spawnPosition, Quaternion.identity);
        RacingCarProduct car = carObject.GetComponent<RacingCarProduct>();
        car.SetColor(Color.blue);
        return car;
    }
}
