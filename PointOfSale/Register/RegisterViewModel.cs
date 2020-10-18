/*
 * Author: Stephanie Krass
 * Class name: RegisterViewModel.cs
 * Purpose: Class used to represent the Register
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using RoundRegister;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// A class representing a register.
    /// </summary>
    /// <remarks>
    /// This class keeps reciept paper and a card reader functionality.
    /// </remarks>
    public class RegisterViewModel 
    {

        // RECIEPT PAPER----------------------------------------------------------------

        /// <summary>
        /// Prints a line on the reciept
        /// </summary>
        /// <param name="line">The text to be printed</param>
        public void PrintLine(string line)
        {
            RecieptPrinter.PrintLine(line);
        }

        /// <summary>
        /// Cuts the register tape
        /// </summary>
        public void CutTape()
        {
            RecieptPrinter.CutTape();
        }

        // CARD READER----------------------------------------------------------------

        /// <summary>
        /// Runs the card
        /// </summary>
        /// <param name="amt">The amount to be run on the card</param>
        /// <returns>
        /// The card transaction result: Approved, Declined
        /// InsufficientFunds, IncorrectPin, or ReadError.
        /// </returns>
        public CardTransactionResult RunCard(double amt)
        {
            return CardReader.RunCard(amt);
        }
    }
}
