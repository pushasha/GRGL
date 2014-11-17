using System;
using Grgl.Concrete.Dialog;
using Grgl.Interfaces.Dialog;

namespace GrglTestDebugApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DialogTree tree = new DialogTree();
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

            Console.WriteLine("END CONVERSATION");
            Console.ReadKey();




        }
    }
}
