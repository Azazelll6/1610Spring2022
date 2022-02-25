using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using Random = System.Random;

public class VariablesAndOperators : MonoBehaviour
{
    readonly int Death = 96;
    private string name = "Zac";
    private Random random = new Random();
    private int timeDelay;

    public VariablesAndOperators()
    {
        //timeDelay = random.Next(5000, 8000);
    }

    async void Start()
    {
       for(var age = 0; age < Death; age++)
       {
           if (age == 0)
           {
               Debug.Log("   Welcome to the world young one! We will name you " + name + ". You will do great things!");
               //Thread.Sleep(timeDelay * 1000); was a cool idea but stops everything
               //WaitForSeconds(timeDelay * 1000); Doesn't work either
               await Task.Delay(timeDelay); //This works as long as you use the System.Threading.Tasks
           }
           else if (age == 12)
           {
               Debug.Log("   Great job" + name + "! You made it passed your first decade. But preteens? Gross, can anyone say angsty?");
               await Task.Delay(timeDelay);
           }
           else if (age == 16)
           {
               Debug.Log("  16 " + name + "? Just make sure to watch out for other cars. We all know your family's luck on the roads....");
               await Task.Delay(timeDelay);
           }
           else if (age == 18)
           {
               Debug.Log(name + " do you think that humans are really adults at such a young age? I mean your brain is still growing right?");
               await Task.Delay(timeDelay);
           }
           else if (age == 21)
           {
               Debug.Log("   Ah " + name + " you can now drink, oh... ah... already going overboard aren't you?");
               await Task.Delay(timeDelay);
           }
           else if (age == 24)
           {
               Debug.Log("   Marriage is what brings us.... Why are you looking at me like that..... I had to!");
               await Task.Delay(timeDelay);
           }
           else if (age == 25)
           {
               Debug.Log("    25.... I mean you can rent a car now..... yay....");
               await Task.Delay(timeDelay);
           }
           else if (age == 40)
           {
               Debug.Log(name + " are those grey hairs I see? you're getting old dude.");
               await Task.Delay(timeDelay);
           }
           else if (age == 50)
           {
               Debug.Log("  Half a decade down, does your back ache yet?");
               await Task.Delay(timeDelay);
           }
           else if (age == 75)
           {
               Debug.Log(name + ", 75 and still going strong. Glad to see life hasn't stopped you yet.");
               await Task.Delay(timeDelay);
           }
           else if (age == 83)
           {
               Debug.Log("   Sorry to see her go " + name + ", but weren't those 59 years great? And at least this will mean your kids have to come see you more!");
               await Task.Delay(timeDelay);
           }
           else if (age == 90)
           {
               Debug.Log("   Wow, 90 years never felt so fast, hope you're still loving every minute.");
               await Task.Delay(timeDelay);
           }
           else if (age == 94)
           {
               Debug.Log(    name + " you're not looking so good... Is there anything I can do to help?");
               await Task.Delay(timeDelay);
           }
           else if (age == 95)
           {
               Debug.Log("    95 years " + name + " that is a lot of time for one person, but now it's time to take you back. And in the end wasn't it all worth it?");
               await Task.Delay(timeDelay);
           }
       }
    }
}

