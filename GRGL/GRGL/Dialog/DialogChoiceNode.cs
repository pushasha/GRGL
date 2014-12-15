// DialogChoiceNode.cs
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
    /// <inheritdoc cref="IDialogChoiceNode" />
    public class DialogChoiceNode : DialogNode, IDialogChoiceNode
    {
        /// <summary>
        /// Creates a new instance of a DialogChoiceNode object
        /// </summary>
        /// <param name="idArg">RefId of this node</param>
        /// <param name="textArg">Text contained in this node</param>
        public DialogChoiceNode(string idArg, string textArg) : base(idArg, textArg)
        {
            this.Choices = new Dictionary<string, IDialogNode>();
        }

        ///  <inheritdoc />
        public IDictionary<string, IDialogNode> Choices { get; private set; }
    }
}
