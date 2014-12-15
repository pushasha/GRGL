// Weapon.cs
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

using Grgl.Other;
using Grgl.Global;

namespace Grgl.Item
{
    ///  <inheritdoc cref="IWeapon"/>
    public class Weapon : Item, IWeapon
    {
        #region Properties
        ///  <inheritdoc />
        public WeaponEquipSlotType EquipSlotType
        {
            get;
            protected set;
        }
        ///  <inheritdoc />
        public IEffect PassiveEffect
        {
            get;
            protected set;
        } 

        #endregion


        /// <summary>
        /// Creates a new instance of a Weapon object
        /// </summary>
        /// <param name="idArg">RefId of this weapon</param>
        /// <param name="nameArg">Human-readable name of this weapon</param>
        public Weapon(string idArg, string nameArg)
            : base(idArg, nameArg)
        {
            // init default property values
            this.EquipSlotType = WeaponEquipSlotType.Primary;
            this.PassiveEffect = null;
        }
        ///  <inheritdoc />
        public void OnEquip()
        {
            throw new System.NotImplementedException();
        }


    }//end class
}