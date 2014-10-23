// IInventory.cs
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

using System;
using System.Collections.Generic;

namespace Grgl.Item.Inventory
{
    public interface IInventory
    {
        /// <summary>
        /// Dictionary of items in player's inventory
        /// <remarks>Key is item BaseId </remarks> // TODO: re-factor so that item can be looked up by name?
        /// </summary>
        IDictionary<string, IInventoryItem> ItemDictionary { get; } 

        /// <summary>
        /// Returns a boolean that evaluates to false if the inventory does not contain any items
        /// </summary>
        bool IsEmpty { get; }
         
    }
}