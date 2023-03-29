using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFactory : MonoBehaviour, IAbstractCarFactory
{
    public GameObject classicCarPrefab;
    public GameObject racingCarPrefab;

    public ICarProduct CreateClassicCar(Vector3 factoryPosition)
    {
        GameObject carObject = GameObject.Instantiate(classicCarPrefab, factoryPosition, Quaternion.identity);
        ClassicCarProduct car = carObject.GetComponent<ClassicCarProduct>();
        car.SetColor(Color.red);
        return car;
    }

    public ICarProduct CreateRacingCar(Vector3 factoryPosition)
    {
        GameObject carObject = GameObject.Instantiate(racingCarPrefab, factoryPosition, Quaternion.identity);
        RacingCarProduct car = carObject.GetComponent<RacingCarProduct>();
        car.SetColor(Color.red);
        return car;
    }
}
