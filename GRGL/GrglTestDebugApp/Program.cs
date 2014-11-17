using System;
using Grgl.Concrete.Character;
using Grgl.Concrete.Dialog;
using Grgl.Interfaces.Dialog;

namespace GrglTestDebugApp
{
    class Program
    {
        private static Npc _olafNpc;
        private static Character _pc;


        static void Main(string[] args)
        {

            InitCharacters();



            Console.Write("Type 'e' to talk to Olaf: ");
            string c = Console.ReadLine();

            if (c == "e")
            {
                DialogTree tree = _pc.Talk(_olafNpc) as DialogTree;

                #region Dialog Loop

                IDialogNode currentNode = tree.Root;
                bool goodbye = false;

                while (!goodbye)
                {
                    Console.WriteLine(currentNode.Text);

                    if (currentNode is IDialogChoiceNode)
                    {
                        foreach (IDialogNode choice in (currentNode as IDialogChoiceNode).Choices.Values)
                        {
                            Console.WriteLine("[" + choice.Id + "]  " + choice.Text);

                        }

                        string input = Console.ReadLine();
                        currentNode = (currentNode as IDialogChoiceNode).Choices[input];
                    }
                    else
                    {
                        Console.ReadKey();
                        if ((currentNode as DialogNode).Flags.ContainsKey("GOODBYE") &&
                            (currentNode as DialogNode).Flags["GOODBYE"] == true)
                        {
                            goodbye = true;
                        }
                        else
                        {
                            currentNode = currentNode.Next;
                        }
                    }


                }

                #endregion
            }

            Console.Write("Do you want to get Olaf's sword? (y/n)");
            c = Console.ReadLine();

            if (c == "y")
            {
                _olafNpc.DialogTree.AddNode("convTopics01", "questEndChoice01");
            }



            Console.WriteLine("END CONVERSATION");
            Console.ReadKey();




        }

        public static void InitCharacters()
        {
            _pc = new Character("Player", "pc001");
            _olafNpc = new Npc("Olaf", "NpcOlaf001");
            


        }



    }
}
