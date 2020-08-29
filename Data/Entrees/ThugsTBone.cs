/*
 * Author: Stephanie Krass
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent Thugs T-Bone
 */using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing Thugs T-Bone
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// Gets the price of Thugs T-Bone
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// Gets the calories of Thugs T-Bone
        /// </summary>
        public uint Calories => 982;

        /// <summary>
        /// Gets the special instructions for Thugs T-Bone
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to return a custom string
        /// </summary>
        /// <returns>The string representation of Thugs T-Bone</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
