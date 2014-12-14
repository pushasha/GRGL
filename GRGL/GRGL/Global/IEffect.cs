// IEffect.cs
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
using Grgl.Character;
using Grgl.Other;

namespace Grgl.Global
{
    /// <summary>
    /// Represents a generic "effect" that changes an aspect of the character for a length of time, or indefinitely
    /// </summary>
    public interface IEffect
    {
        /// <summary>
        /// The elemental type of this effect, if applicable
        /// </summary>
        ElementalType Element { get; } // TODO: Rename?
        
        /// <summary>
        /// A dictionary containing the resources modified by this effect, and a value with which to modify that resource
        /// </summary>
        IDictionary<ICharacterResource, float> CharacterResourceModifier { get; } //TODO: Integrate ModifyTrait delegate

        /// <summary>
        /// A dictionary containing the stats modified by this effect, and a value with which to modify that stat
        /// </summary>
        IDictionary<string, float> NumericStatModifier { get; }  //TODO: Integrate ModifyTrait delegate


        /// <summary>
        /// The amount of time this effect should last in seconds (values below zero indicate a passive effect)
        /// </summary>
        float TimeLength { get; }
    }

    /// <summary>
    /// A delegate type that takes an integer value of a trait and modifies it in some way
    /// </summary>
    /// <param name="traitVal">The current value of the trait to be modified</param>
    /// <returns>The modified value of the trait</returns>
    public delegate int ModifyTrait(int traitVal);
    
}