using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;
    //public int socialClass;
    //public string badges;
    //public string locations;
    //public string food;
    //public string weapon;
    //public int korokSeeds;
    //public int toDoList;
    //public int strengthPnts;
    //public int wisdomPnts;

    void Start()
    {
        switch (npcConv)
        {
            case "Hello":
                print("Hello good citizen! May Zandar bless your face.");
                break;
            case "Goodbye":
                print("Goodbye! Safe travels!");
                break;
            case "We are being attacked!":
                print("Run away in shame, you coward!");
                break;
        }

        /*
        switch(socialClass)
        {
            case 5:
                print("Hello, you're Magesty, please sign my new born child!");
                break;
            case 4:
                print("Hello, Bishop, you are looking very holy today!");
                break;
            case 3:
                print("Hello, Rook, you seem to have a straight forward look, what's on your mind?");
                break;
            case 2:
                print("Sir knight, your horse smells better than you.");
                break;
            case 1:
                print("Mr. Pawn, you must die soon, the Queen told me so.");
                break;
            case 0:
                print("Player, don't even talk to me.");
                break;
            default:
                print("Meeehhhhh");
                break;
        }

        switch (strengthPnts)
        {
            case 3:
                print("Wow, you're to beefiest cake I've ever seen. I will die for you in battle.");
                break;
            case 2:
                print("Bro, sweet gains, you're almost intimidating");
                break;
            case 1:
                print("Really? You just got a membership at the gym? I would'nt have noticed.");
                break;
            case 0:
                print("You're as lanky and Pete Davidson, get out of here!");
                break;
        }

        switch (wisdomPnts)
        {
            case 3:
                print("Please, slow down! I can only type 120 words per minute, professor!");
                break;
            case 2:
                print("I feel like I can trust you with refinancing my house.");
                break;
            case 1:
                print("You're street smart but you're not book smart.");
                break;
            case 0:
                print("Go learn some life skills, you're still a baby.");
                break;
        }
        
        switch (toDoList)
        {
            case 3:
                print("Wow, thanks for getting everything that I needed from Target, Link!");
                break;
            case 2:
                print("Link, you forgot the hog jaw that I needed for tonights BBQ.");
                break;
            case 1:
                print("What's this? You only got one thing from my list! This will not do!");
                break;
            case 0:
                print("You did'nt even go to the store!");
                break;
        }

        switch (korokSeeds)
        {
            case 3:
                print("Wow! You found all the poop seeds Link, here is a giant turd for all your efforts."  );
                break;
            case 2:
                print("You've almost collected all the korok seeds, you only need to find one more to get your suprise.");
                break;
            case 1:
                print("You're collectation has only just begun.");
                break;
            case 0:
                print("What are you doing? Go find the korok seeds, fetch!");
                break;
        }

        switch (badges)
        {
            case "Rock":
                print("You dont have your rock badge, to to uncle joe's and battle it out.");
                break;
            case "Electric":
                print("You have'nt recieved your Electricity badge, go like a power pole!");
                break;
            case "Fire":
                print("You have'nt gotten your fire badge, go sit in that broken sauna back at Park City!");
                break;
            case "Water":
                print("Take a dunk in the lake, you didn't earn that glorious aqua badge!");
                break;
        }

        switch (locations)
        {
            case "St.George":
                print("Hey wow, I'm from St.George as well!");
                break;
            case "Provo":
                print("I currently live in Provo! I moved here for school and work.");
                break;
            case "Park City":
                print("Park City is really nice, cost of living there and owning your own property is insane.");
                break;
            case "Santa Clara":
                print("I love Santa Clara, I always come down every month to go visit my parents there.");
                break;
        }

        switch (weapon)
        {
            case "Hand Gun":
                print("The Hand Gun is a potent weapon, it's for pistol whipping your enemys.");
                break;
            case "Shot Gun":
                print("The shot gun would suit you well, you have very poor aim in close quarters");
                break;
            case "Bazooka":
                print("Hey if you wanna have fun blowing things up, the bazooka will do just that!");
                break;
            case "Knife":
                print("Great for cutting onions, not so great if you're in a gun fight.");
                break;
        }

        switch (food)
        {
            case "Cupcake":
                print("Nice, the cupcake restored your health by 12.");
                break;
            case "Pizza":
                print("Aww yeah, your HP has been restored by 15.");
                break;
            case "Ciggy":
                print("Your HP went down by 10 but your PP went up by 5.");
                break;
            case "Mint Julep":
                print("Wowza, your HP is fully restored!");
                break;
        }
        */
    }
}
