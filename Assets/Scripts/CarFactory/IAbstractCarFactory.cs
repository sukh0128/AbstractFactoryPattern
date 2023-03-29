using UnityEngine;

public interface IAbstractCarFactory 
{
    ICarProduct CreateClassicCar(Vector3 spawnPosition);
    ICarProduct CreateRacingCar(Vector3 spawnPosition);
}
