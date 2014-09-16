using Grgl.Dialog;

namespace GrglTestApp.Dialog
{
    public class DialogTree : IDialogTree
    {
        public IDialogNode Root { get; private set; }

        public DialogTree()
        {
            // set root node
            Root = null;
            ConstructDialogTree();
        }

        private void ConstructDialogTree()
        {
            // construct dialog lines
            DialogLine d001 = new DialogLine("Hey, Captain.");
            DialogLine d002 = new DialogLine("What's your opinion of the last mission?");
            DialogLine d003 = new DialogLine("Well, that depends. Did you kill Bob on purpose?");
            DialogLine d004 = new DialogLine("No, I wish I could have done something.");
            DialogLine d005 = new DialogLine("No, but I'm glad he's dead.");
            DialogLine d006 = new DialogLine("Yes, and he deserved it, the bastard.");
            DialogLine d007 = new DialogLine("I'm glad you feel some kind of remorse.");
            DialogLine d008 = new DialogLine("Can't say I agree with you, but I guess what's done is done.");
            DialogLine d009 = new DialogLine("Wow, you're an awful person. I hope you're happy, captain.");

            // construct choice nodes
            DialogChoiceNode c001 = new DialogChoiceNode();
            DialogChoiceNode c002 = new DialogChoiceNode();
            
            // add choices to choice nodes
            c001.Choices.Add(d002.Text, d002);

            c002.Choices.Add(d004.Text, d004);
            c002.Choices.Add(d005.Text, d005);
            c002.Choices.Add(d006.Text, d006);

            // Link nodes in numerical order
            d001.Next = c001;
            d002.Next = d003;
            d003.Next = c002;
            d004.Next = d007;
            d005.Next = d008;
            d006.Next = d009;

            // set root node
            Root = d001;
        }// end construct dialog tree

        
    }
}