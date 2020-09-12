/*
 * Author: Stephanie Krass
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent Thugs T-Bone
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing Thugs T-Bone
    /// </summary>
    /// <remarks>
    /// This class keeps track of the price, calories,
    /// and special instructions for a Thugs T-Bone.
    /// </remarks>
    public class ThugsTBone : Entree
    {
        /// <value>
        /// Gets the price of Thugs T-Bone
        /// </value>
        public override double Price => 6.44;

        /// <value>
        /// Gets the calories of Thugs T-Bone
        /// </value>
        public override uint Calories => 982;

        /// <value>
        /// Gets the special instructions for Thugs T-Bone
        /// </value>
        public override List<string> SpecialInstructions
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
        /// <returns>
        /// The string representation of Thugs T-Bone
        /// </returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
