// ElementalType.cs
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

namespace Grgl.Other
{
    /// <summary>
    /// This is a faux-extensible "enum" class.
    /// </summary>
    /// <remarks>
    /// To extend this class and add values to this "enum", use the following syntax:
    /// <code>
    /// public class ElementalTypeExtended : ElementalType
    /// {
    ///		public ElementalTypeExtended (int value) : base(value) {}
    ///
    ///		public const int EnumeratorToAdd = 4; // where this value is one that hasn't been assigned in the definition of the enum being extended
    ///		public const int AnotherEnumerator = 5;
    /// }
    /// </code>
    /// </remarks>
    public class ElementalType
    {
        public int Value { get; set; }
		
        public ElementalType (int value)
        {
            Value = value;
        }

        public static implicit operator int(ElementalType arg)
        {
            return arg.Value;
        }

        public static implicit operator ElementalType(int value)
        {
            return new ElementalType(value);
        }

        public const int Fire = 1;
        public const int Ice = 2;
        public const int Poison = 3;

    }// end class
}
