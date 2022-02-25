using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalsAndSwitches : MonoBehaviour 
{
    string Difficulty = "Hard";
    int Floor = 1;
    double EnemyDamage;
    double InitialEnemyDamage;
    double EnemyHealth;
    double InitialEnemyHealth;
    double DifficultyIncrease;

    void Start()
    {
        switch (Difficulty)
        {
            case "Easy":
                InitialEnemyDamage = 1;
                InitialEnemyHealth = 10;
                DifficultyIncrease = 1.2;
                break;
            case "Medium":
                InitialEnemyDamage = 5;
                InitialEnemyHealth = 25;
                DifficultyIncrease = 2.5;
                break;
            case "Hard":
                InitialEnemyDamage = 10;
                InitialEnemyHealth = 50;
                DifficultyIncrease = 5;
                break;
            default:
                InitialEnemyDamage = 5;
                InitialEnemyHealth = 25;
                DifficultyIncrease = 2.5;
                break;
        }

        Console.WriteLine("Starting floor " + Floor);
        
        if(Floor == 1)
        {    
            Console.WriteLine("Welcome to Floor 1!");
            EnemyDamage = InitialEnemyDamage;
            EnemyHealth = InitialEnemyHealth;
            Console.WriteLine("Enemy's Damage = " + InitialEnemyDamage);
            Console.WriteLine("Enemy's Health = " + InitialEnemyHealth);
        }
        else if(Floor > 1 & Floor < 10)
        {
            Console.WriteLine("Floor " + Floor);
            EnemyDamage = InitialEnemyDamage + (Floor * DifficultyIncrease);
            EnemyHealth = InitialEnemyHealth + (Floor * DifficultyIncrease);
            Console.WriteLine("Enemy Damage = " + EnemyDamage + "Enemy Health = " + EnemyHealth);
        }
        else if(Floor >= 10 & Floor < 30)
        {
            Console.WriteLine("Floor " + Floor);
            EnemyDamage = InitialEnemyDamage + (Floor * DifficultyIncrease);
            EnemyHealth = InitialEnemyHealth + (Floor * DifficultyIncrease);
            Console.WriteLine("Enemy Damage = " + EnemyDamage + "Enemy Health = " + EnemyHealth);
        }
        else if (Floor >= 20 & Floor < 40)
        {
            Console.WriteLine("Floor " + Floor);
            EnemyDamage = InitialEnemyDamage + (Floor * DifficultyIncrease);
            EnemyHealth = InitialEnemyHealth + (Floor * DifficultyIncrease);
            Console.WriteLine("Enemy Damage = " + EnemyDamage + "Enemy Health = " + EnemyHealth);
        } 
        else if (Floor >= 30 & Floor < 50)
        {
            Console.WriteLine("Floor " + Floor);
            EnemyDamage = InitialEnemyDamage + (Floor * DifficultyIncrease);
            EnemyHealth = InitialEnemyHealth + (Floor * DifficultyIncrease);
            Console.WriteLine("Enemy Damage = " + EnemyDamage + "Enemy Health = " + EnemyHealth);
        }
        else if (Floor == 50)
        {
            Console.WriteLine("Welcome to the final level, Good luck!");
            EnemyDamage = InitialEnemyDamage + (Floor * DifficultyIncrease);
            EnemyHealth = InitialEnemyHealth + (Floor * DifficultyIncrease);
            Console.WriteLine("Enemy Damage = " + EnemyDamage + "Enemy Health = " + EnemyHealth);
        }
        else
        {
            Console.WriteLine("Congratulations you beat the game!");
        }
    }
}