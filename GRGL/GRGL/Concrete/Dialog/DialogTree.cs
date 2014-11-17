// DialogTree.cs
// (c) Copyright Sarah Plotkin (splotkin@gmail.com)
// 
// This file is part of GRGL.
// GRGL is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// GRGL is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.

// You should have received a copy of the GNU Lesser General Public License
// along with GRGL.  If not, see <http://www.gnu.org/licenses/>.

using System.ComponentModel;
using Grgl.Interfaces.Dialog;

namespace Grgl.Concrete.Dialog
{
    public class DialogTree : IDialogTree
    {
        public DialogTree(IDialogNode rootNode)
        {
            this.Root = rootNode;
        }

        public DialogTree()
        {
            InitSample();
        }

        #region Properties

        public IDialogNode Root { get; private set; }

        #endregion

        #region Methods

        private void InitSample()
        {

            DialogNode greeting = new DialogNode("greeting01", "Hey there, lass.");
            DialogChoiceNode convTopics = new DialogChoiceNode("convTopics01", "What do you want to know?");

            DialogNode questStartChoice = new DialogNode("questStartChoice01", "Need any help?");
            DialogNode questStart = new DialogNode("questStart01", "Yeah, actually. I have a sword over there that I'm too lazy to pick up. Mind getting it for me?");

            DialogNode goodbyeChoice = new DialogNode("goodbyeChoice01", "I should go.");
            DialogNode goodbye = new DialogNode("goodbye01", "Until next time, lass.");
            DialogNode gossipChoice = new DialogNode("gossipChoice01", "Hear anything interesting around town?");
            DialogNode gossip = new DialogNode("gossip01", "Nah, I don't pay too much attention.");
            
            DialogNode questEndChoice = new DialogNode("questEndChoice01", "I brought you the sword.");
            DialogNode questEnd = new DialogNode("questEnd01", "Thank you so much, lass!");

            greeting.Next = convTopics;
            convTopics.Choices.Add("questStartChoice01", questStartChoice);
            convTopics.Choices.Add("gossipChoice01", gossipChoice);
            convTopics.Choices.Add("goodbyeChoice01", goodbyeChoice);

            questStartChoice.Next = questStart;
            questStart.Next = convTopics;

            gossipChoice.Next = gossip;
            gossip.Next = convTopics;

            goodbyeChoice.Next = goodbye;
            goodbye.Flags["GOODBYE"] = true;


            questEndChoice.Next = questEnd;
            questEnd.Next = convTopics;

            this.Root = greeting;

        }

        #endregion


    }
}
