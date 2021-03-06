﻿// IRequirements.cs
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

namespace Grgl.Character
{
    /// <summary>
    /// Represents a collection of abstract requirements
    /// </summary>
    public interface IRequirements : IDictionary<string, IRequirement>
    {
        /// <summary>
        /// Method that checks whether needed requirements are met for a given task
        /// </summary>
        /// <param name="traitsToCheck">Dictionary of traits to check</param>
        /// <returns>True if requirements met, false if not met.</returns>
        bool MeetsRequirements(IDictionary<string, ICharacterTrait> traitsToCheck);
    }
}