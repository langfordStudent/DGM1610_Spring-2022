using UnityEngine;

enum Color { blue, red, yellow, green, orange, purple };
enum CarMake { Toyota, Ford, Mazda, Chevrolet, Dodge, Acura };
enum CarModel { Tacoma, Cruze, Mustang, Miata, Viper, Alero };
enum Food { Pizza, Cake, Carrot, Potato, Steak, Corndog, Skittles };
enum Liquidity { ETH, BTC, USDC, JUNO, USDT, DOGE };
enum PrimaryColors { Red, Yellow, Blue};
enum SecondaryColors { Green, Purple, Orange};
enum Movie { DespicableMe, Antz, ToyStory, IceAge, Totoro}
enum Studio { Illumination, Dreamworks, Pixar, BlueSky, Ghibli}
enum Animals { Lion, Tiger, Bear, Goat, Lizard, MobyDick}

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

        /*
        PrimaryColors baseColor;
        SecondaryColors finalColor;

        

        baseColor = PrimaryColors.Red;
        finalColor = SecondaryColors.Purple;

        FindColor(baseColor, finalColor);
        */

        /*
        Movie movie;
        Studio studio;

        movie = Movie.ToyStory;
        studio = Studio.Pixar;

        WhoMadeIt(movie, studio);
        */
        
        /*
        Animals animal;

        animal = Animals.Bear;

        print(animal);
        */

        RecallCars(CarMake.Ford, CarModel.Mustang);

    }

    void RecallCars(CarMake make, CarModel model)
    {
        if (make == CarMake.Toyota && model == CarModel.Alero)
        {
            print("Your car has been requested for recall do to airbags not saving people.");
        }
        else if (make == CarMake.Ford && model == CarModel.Mustang)
        {
            print("There is a recall for mustrangs for being to cool to drive.");
        }
        else
        {
            print("There is no recall notice for your vehicle make and model.");
        }
    }

    /*
    void FindColor(PrimaryColors baseColor, SecondaryColors finalColor)
    {
        if (baseColor == PrimaryColors.Red && finalColor == SecondaryColors.Orange)
        {
            print("You need " + PrimaryColors.Yellow + " to make " + finalColor);
        }
        else if (baseColor == PrimaryColors.Red && finalColor == SecondaryColors.Purple)
        {
            print("You need " + PrimaryColors.Blue + " to make " + finalColor);
        }
        else if (baseColor == PrimaryColors.Blue && finalColor == SecondaryColors.Green)
        {
            print("You need " + PrimaryColors.Yellow + " to make " + finalColor);
        }
        else if (baseColor == PrimaryColors.Blue && finalColor == SecondaryColors.Purple)
        {
            print("You need " + PrimaryColors.Red + " to make " + finalColor);
        }
        else if (baseColor == PrimaryColors.Yellow && finalColor == SecondaryColors.Orange)
        {
            print("You need " + PrimaryColors.Red + " to make " + finalColor);
        }
        else if (baseColor == PrimaryColors.Yellow && finalColor == SecondaryColors.Green)
        {
            print("You need " + PrimaryColors.Blue + " to make " + finalColor);
        }
        else
        {
            print(baseColor + " cannot mix with another primary color to make " + finalColor);
        }

        void WhoMadeIt(Movie movie, Studio studio)
        {
            if(movie == Movie.ToyStory && studio == Studio.Pixar)
            {
                Debug.Log(studio + " did make " + movie);
            }
            else if(movie == Movie.Antz && studio == Studio.Dreamworks)
            {
                Debug.Log(studio + " did make " + movie);
            }
            else if (movie == Movie.Totoro && studio == Studio.Ghibli)
            {
                Debug.Log(studio + " did make " + movie);
            }
            else if (movie == Movie.IceAge && studio == Studio.BlueSky)
            {
                Debug.Log(studio + " did make " + movie);
            }
            else
            {
                Debug.Log(studio + " did'nt make " + movie);
            }
        }    
    }
    */
}
