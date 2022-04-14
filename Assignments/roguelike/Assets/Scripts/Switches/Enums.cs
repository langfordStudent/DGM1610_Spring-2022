using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Color {blue, red, yellow, green, orange, purple};
enum CarMake {Toyota, Ford, Mazda, Chevrolet, Dodge, Acura};
enum CarModel {Tacoma, Cruze, Mustang, Miata, Viper, Alero};
enum Food { Pizza, Cake, Carrot, Potato, Steak, Corndog, Skittles};
enum liquidity { ETH, BTC, USDC, JUNO, USDT, DOGE};

public class Enums : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        Color paint;
        paint = Color.blue;

        print(paint);
        */

        /*
        CarMake make;
        CarModel model;
                
        make = CarMake.Dodge;
        model = CarModel.Viper;
        
        print("Car manufacture: " + make + " Model: " + model);
        */

        /*
        liquidity pairOne;
        liquidity pairTwo;

        pairOne = liquidity.ETH;
        pairTwo = liquidity.BTC;

        if(pairOne == pairTwo)
        {
            print("You cannot trade " + pairOne + " for " + pairTwo + ", dummy.");
        }
        else
        {
            print("You can trade " + pairOne + " for " + pairTwo + " @ Binance.US");
        }
        */

        /*
        Food foodOne;
        Food foodTwo;

        foodOne = Food.Carrot;
        foodTwo = Food.Cake;

        if (foodOne == Food.Cake && foodTwo == Food.Carrot)
        {
            print(foodOne + " & " + foodTwo + " are a good combination!");
        }
        else if (foodOne == Food.Carrot && foodTwo == Food.Cake)
        {
            print(foodOne + " & " + foodTwo + " are a good combination!");
        }
        else
            print("Gross.");
        */

        RecallCars(CarMake.Ford, CarModel.Mustang);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void RecallCars(CarMake make, CarModel model)
    {
        if(make == CarMake.Toyota && model == CarModel.Alero)
        {
            print("Your car has been requested for recall do to airbags not saving people.");
        }
        else if(make == CarMake.Ford && model == CarModel.Mustang)
        {
            print("There is a recall for mustrangs for being to cool to drive.");
        }
        else
        {
            print("There is no recall notice for your vehicle make and model.");
        }
    }
}
