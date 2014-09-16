using System;
using System.Collections.Generic;
using Grgl.Dialog;

namespace GrglTestApp.Dialog
{
    public class DialogChoiceNode : IDialogChoiceNode
    {
        public string Id { get; private set; }
        public string Text { get; private set; }
        public Dictionary<string, IDialogLine> Choices { get; private set; }

        public DialogChoiceNode()
        {
            Id = Guid.NewGuid().ToString();
            Text = "";
            Choices = new Dictionary<string, IDialogLine>();
        }
    }
}