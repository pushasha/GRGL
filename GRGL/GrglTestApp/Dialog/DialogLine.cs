using System;
using System.Collections.Generic;
using Grgl.Dialog;

namespace GrglTestApp.Dialog
{
    public class DialogLine : IDialogLine
    {
        public string Id { get; private set; }
        public string Text { get; private set; }
        public IDialogNode Next { get; set; }

        public DialogLine(string textParam)
        {
            Id = Guid.NewGuid().ToString();
            Text = textParam;
            Next = null;
        }
    }
}