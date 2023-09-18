//hi
Console.WriteLine("Lost in the woods, you find yourself infront of a sleeping Hound. You can see a campfire in the distance but must pass the beast to reach it.");
Console.WriteLine("Will you go towards the fire or not? (yes/no)");

string Choice1 = Console.ReadLine().ToLower();

if (Choice1 == "yes")
 {Console.WriteLine("Sneaking across, you manage to snap a twig on the ground and wake the beast. Quickly you sprint towards the fire, Hound chasing near behind. A path to the Left is visible.");
    Console.WriteLine("Will you turn left or continue towards the fire? (yes/no)");
    string Choice2 = Console.ReadLine().ToLower();
    if (Choice2 == "yes")
    {
     Console.WriteLine("Abandoning the light, you turn left. As the path grows wider you see a clearing in the distance, however, you realise you are faced only with a cliffs edge and the great ocean beyond it.");
     Console.WriteLine("Unable to choose which way to perish, you reminisce on life as the Hound inevitably ravages you. ");
     Console.ReadLine();

    }
    else if (Choice2 == "no")
    {
     Console.WriteLine("As the fire grows brighter in your eyes, the sounds of soldiers deep in training can be heard. As you scream for help, they rush over to you, fending off the beast.");
     Console.WriteLine("Though you live to see another day, another soldier who fought in your stead will not.");
     Console.ReadLine();
    }
    else if (Choice2 != "no" | Choice2 != "yes")
    {
      Console.WriteLine("wrong input");
      Console.ReadLine();
    }
    
}
else if (Choice1 == "no")
{
 Console.WriteLine("Deciding to back off, you try to retrace your steps. In time, you find yourself on the outskirts of a thick fog, blanketing the woods.");
 Console.WriteLine("Will you enter the fog? (yes/no)");
 string Choice3 = Console.ReadLine().ToLower();
 if (Choice3 == "yes")
 {
   Console.WriteLine("As you step further into the fog, your vision grows worse; unable to see the ground beneath you. Soon you begin to feel something amiss.");
   Console.WriteLine("The fog creeps into your mind, your thoughts begin to blur.");
   Console.WriteLine("Who are you?");
   Console.WriteLine("Who am i?");
   Console.ReadLine();
 }
 else if (Choice3 == "no")
 {
   Console.WriteLine("Deciding to avoid the fog, you turn left and right and continue your wandering. Soon in the in distance you see a clearing.");
   Console.WriteLine("As you approach, your village begins to be seen. You run back to your house, where your kids greet you with a hug.");
   Console.WriteLine("You are finally home.");
   Console.ReadLine();
 }
 else if (Choice3 != "no" | Choice3 != "yes")
    {
      Console.WriteLine("wrong input");
    }
}
else if (Choice1 != "no" | Choice1 != "yes")
    {
      Console.WriteLine("wrong input");
      Console.ReadLine();
    }
    
    






