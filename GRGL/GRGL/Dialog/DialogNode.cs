// DialogNode.cs
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
using Grgl.Global;

namespace Grgl.Dialog
{
    /// <inheritdoc cref="IDialogNode" />
    public class DialogNode : IDialogNode, IHasFlags
    {
        /// <summary>
        /// Creates a new instance of a DialogNode object
        /// </summary>
        /// <param name="idArg">RefId of this node</param>
        /// <param name="textArg">The dialog text contained in this node</param>
        public DialogNode(string idArg, string textArg)
        {
            this.Id = idArg;
            this.Text = textArg;
            this.Flags = new Dictionary<string, bool>();
        }

        /// <summary>
        /// Creates a new instance of a DialogNode object
        /// </summary>
        /// <param name="idArg">RefId of this node</param>
        public DialogNode(string idArg): this(idArg, "PLACEHOLDER TEXT"){ }
        
        ///  <inheritdoc />
        public string Id { get; protected set; }
        
        ///  <inheritdoc />
        public string Text { get; set; }

        ///  <inheritdoc />
        public IDialogNode Next { get; set; }

        ///  <inheritdoc />
        public IDictionary<string, bool> Flags { get; protected set; }
    } 
}
