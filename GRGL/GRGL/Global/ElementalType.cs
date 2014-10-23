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

namespace Grgl.Global
{
    /// <remarks>
    /// This class emulates the behavior of an enum, but allows for extensibility.
    /// To extend this "enum", i.e. to add members, create an extension class that implements this
    /// base class, declare/define your custom values, and override the constructor as follows:
    /// <code>
    /// public class ElementalTypeExtension : ElementalType {
    ///	    public const int CustomValue = 5;
    ///     // add more values...
    ///	    public ElementalTypeExtension (int value) : base (value) {}
    /// }
    /// </code>
    /// </remarks>
    public class ElementalType
    {

        public int Value { get; set; }

        public const int Normal = 1;
        public const int Poison = 2;
        public const int Fire = 3;
        public const int Water = 4;


        public ElementalType(int value)
        {
            Value = value;
        }

        public static implicit operator int(ElementalType extEnum)
        {
            return extEnum.Value;
        }

        public static implicit operator ElementalType(int value)
        {
            return new ElementalType(value);
        }

         
    }
}