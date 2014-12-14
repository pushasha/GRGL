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

using System.Collections.Generic;

namespace Grgl.Dialog
{
    /// <inheritdoc cref="IDialogTree" />
    public class DialogTree : IDialogTree
    {
        ///  <inheritdoc />
        public DialogTree(IDialogNode rootNode)
        {
            this.Root = rootNode;
            this.NodeDictionary = new Dictionary<string, IDialogNode>();
        }

        ///  <inheritdoc />
        public DialogTree()
        {
            this.NodeDictionary = new Dictionary<string, IDialogNode>();
            InitSample();
        }

        #region Properties
        ///  <inheritdoc />
        public IDialogNode Root { get; private set; }

        ///  <inheritdoc />
        public IDictionary<string, IDialogNode> NodeDictionary { get; private set; }

        #endregion

        #region Methods

        ///  <inheritdoc />
        public void AddNode(string parentId, IDialogNode nodeToAdd)
        {
            if (!this.NodeDictionary.ContainsKey(nodeToAdd.Id))
            {
                this.NodeDictionary[nodeToAdd.Id] = nodeToAdd;
            }

            if (this.NodeDictionary[parentId] is IDialogChoiceNode)
            {
                DialogChoiceNode parentChoice = this.NodeDictionary[parentId] as DialogChoiceNode;


                if (parentChoice != null) parentChoice.Choices.Add(nodeToAdd.Id, this.NodeDictionary[nodeToAdd.Id]);
            }
            else
            {
                this.NodeDictionary[parentId].Next = this.NodeDictionary[nodeToAdd.Id];
            }
        }

        ///  <inheritdoc />
        public void AddNode(string parentId, string nodeToAddId)
        {

            if (this.NodeDictionary[parentId] is IDialogChoiceNode)
            {
                DialogChoiceNode parentChoice = this.NodeDictionary[parentId] as DialogChoiceNode;


                if (parentChoice != null) parentChoice.Choices.Add(nodeToAddId, this.NodeDictionary[nodeToAddId]);
            }
            else
            {
                this.NodeDictionary[parentId].Next = this.NodeDictionary[nodeToAddId];
            }
        }

        private void InitSample()
        {

            this.NodeDictionary["greeting01"] = new DialogNode("greeting01", "Hey there, lass.");
            this.NodeDictionary["convTopics01"] = new DialogChoiceNode("convTopics01", "What do you want to know?");

            this.NodeDictionary["questStartChoice01"] = new DialogNode("questStartChoice01", "Need any help?");
            this.NodeDictionary["questStart01"] = new DialogNode("questStart01", "Yeah, actually. I have a sword over there that I'm too lazy to pick up. Mind getting it for me?");

            this.NodeDictionary["goodbyeChoice01"] = new DialogNode("goodbyeChoice01", "I should go.");
            this.NodeDictionary["goodbye01"] = new DialogNode("goodbye01", "Until next time, lass.");
            this.NodeDictionary["gossipChoice01"] = new DialogNode("gossipChoice01", "Hear anything interesting around town?");
            this.NodeDictionary["gossip01"] = new DialogNode("gossip01", "No, I don't pay too much attention.");

            this.NodeDictionary["questEndChoice01"] = new DialogNode("questEndChoice01", "I brought you the sword.");
            this.NodeDictionary["questEnd01"] = new DialogNode("questEnd01", "Thank you so much, lass!");

            this.NodeDictionary["greeting01"].Next = this.NodeDictionary["convTopics01"];
            (this.NodeDictionary["convTopics01"] as DialogChoiceNode).Choices.Add("questStartChoice01", this.NodeDictionary["questStartChoice01"]);
            (this.NodeDictionary["convTopics01"] as DialogChoiceNode).Choices.Add("gossipChoice01", this.NodeDictionary["gossipChoice01"]);
            (this.NodeDictionary["convTopics01"] as DialogChoiceNode).Choices.Add("goodbyeChoice01", this.NodeDictionary["goodbyeChoice01"]);

            this.NodeDictionary["questStartChoice01"].Next = this.NodeDictionary["questStart01"];
            this.NodeDictionary["questStart01"].Next = this.NodeDictionary["convTopics01"];

            this.NodeDictionary["gossipChoice01"].Next = this.NodeDictionary["gossip01"];
            this.NodeDictionary["gossip01"].Next = this.NodeDictionary["convTopics01"];

            this.NodeDictionary["goodbyeChoice01"].Next = this.NodeDictionary["goodbye01"];
            (this.NodeDictionary["goodbye01"] as DialogNode).Flags["GOODBYE"] = true;


            this.NodeDictionary["questEndChoice01"].Next = this.NodeDictionary["questEnd01"];
            this.NodeDictionary["questEnd01"].Next = this.NodeDictionary["convTopics01"];

            this.Root = this.NodeDictionary["greeting01"];

        }

        #endregion


    }
}
