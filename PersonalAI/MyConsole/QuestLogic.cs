using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsole
{
    public class QuestLogic
    {
        public static QuestLogic? Instance;
        public static bool CanFastAttack(bool isKnightAwake)
        {
            if (isKnightAwake)
            {
                System.Console.WriteLine("They are awake!!");
                return true;
            }
            else
            {
                System.Console.WriteLine("Fast Attack!!");
                return false;
            }
        }
        public static bool CanSpy(bool isKnightAwake, bool isArcherAwake, bool isPrisonerAwake)
        {
            if (!isKnightAwake && isArcherAwake)
            {
                if (!isPrisonerAwake)
                {
                    System.Console.WriteLine("Can Spy");
                    return true;
                }
                else
                {
                    System.Console.WriteLine("Can't Spy");
                    return false;
                }
            }
            System.Console.WriteLine("Can't Spy");
            return false;
        }


        public static bool CanSignal(bool isArcherAwake, bool isPrisonerAwake)
        {
            if (!isArcherAwake && isPrisonerAwake)
            {
                System.Console.WriteLine("Wake Up!!");
                return true;
            }
            else
            {
                System.Console.WriteLine("Better keep it down....");
                return false;
            }
        }

        public static bool CanFreePrisoner(bool isKnightAwake, bool isArcherAwake, bool isPrisonerAwake, bool isDogPresent)
        {
            if (!isKnightAwake && isArcherAwake && !isPrisonerAwake && isDogPresent)
            {
                System.Console.WriteLine("Let's get the fuck out of here!!!");
                return true;
            }
            else
            {
                System.Console.WriteLine("I shouldn't go yet...");
                return false;
            }
        }
    }

}