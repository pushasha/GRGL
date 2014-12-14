// Inventory.cs
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

namespace Grgl.Item
{
    /// <inheritdoc cref="IInventory" />
    public class Inventory : IInventory
    {
        private readonly Dictionary<string, IInventoryItem> _itemDictionary;

        ///  <inheritdoc />
        public Inventory()
        {
            _itemDictionary = new Dictionary<string, IInventoryItem>();
        }

        ///  <inheritdoc />
        public IDictionary<string, IInventoryItem> ItemDictionary
        {
            get { return _itemDictionary; }
        }

        ///  <inheritdoc />
        public bool IsEmpty
        {
            get { return _itemDictionary.Count == 0; } // TODO: Check to see if there are keys, but no values
        }
    }
}
