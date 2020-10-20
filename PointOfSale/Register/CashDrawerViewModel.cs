/*
 * Author: Stephanie Krass
 * Class name: CashDrawerViewModel.cs
 * Purpose: Class used to represent the cashdrawer of the register
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using RoundRegister;


namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// A class representing a register's cash drawer.
    /// </summary>
    /// <remarks>
    /// This class keeps track of the pennies, nickles, dimes,
    /// quarters, dollars, half dollars, ones, twos, fives,
    /// tens, twenties, fifties, and hundreds available.
    /// </remarks>
    /// <remarks>
    /// This class keeps track of the total and allows the 
    /// cash drawer to open and be reset. 
    /// </remarks>
    public class CashDrawerViewModel : INotifyPropertyChanged
    {
        #region Private Variables
        /*Private Variable*/
        private double orderCost = 0;
        private bool sufficientPayment = false;
        private double currentPayment = 0;
        private double amountDue = 0;
        private double changeDue = 0;

        /* Private Variable Declarations For Customer Payment*/
        private int paidPennies = 0;
        private int paidNickels = 0;
        private int paidDimes = 0;
        private int paidQuarters = 0;
        private int paidDollars = 0;
        private int paidHalfDollars = 0;
        private int paidOnes = 0;
        private int paidTwos = 0;
        private int paidFives = 0;
        private int paidTens = 0;
        private int paidTwenties = 0;
        private int paidFifties = 0;
        private int paidHundreds = 0;

        /* Private Variable Declarations For Change*/
        private int chgPennies = 0;
        private int chgNickels = 0;
        private int chgDimes = 0;
        private int chgQuarters = 0;
        private int chgDollars = 0;
        private int chgHalfDollars = 0;
        private int chgOnes = 0;
        private int chgTwos = 0;
        private int chgFives = 0;
        private int chgTens = 0;
        private int chgTwenties = 0;
        private int chgFifties = 0;
        private int chgHundreds = 0;
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The total cost of the order placed
        /// </summary>
        public double OrderCost
        {
            get{return orderCost;}
            set{orderCost = value;}
        }

        /// <summary>
        /// Holds whether or not there is sufficient funds to pay for the meal
        /// </summary>
        public bool SufficientPayment
        {
            get
            {
                if (CurrentPayment >= OrderCost) sufficientPayment = true;
                else sufficientPayment = false;
                    
                return sufficientPayment;
            }
        }

        /// <summary>
        /// The current payment amount 
        /// </summary>
        public double CurrentPayment
        {
            get
            {
                currentPayment =  PaidPennies * 0.01 + PaidNickels * 0.05 + PaidDimes * 0.10 + PaidQuarters * 0.25 + 
                                 PaidHalfDollars * 0.50 + PaidDollars * 1.0 +
                                 PaidOnes * 1.00 + PaidTwos * 2.00 + PaidFives * 5.00 + PaidTens * 10.00 + 
                                 PaidTwenties * 20.0 + PaidFifties * 50.0 + PaidHundreds * 100.0;
                return currentPayment;
            }
        }

        /// <summary>
        /// The current payment amount 
        /// </summary>
        public double CurrentChangeDue
        {
            get{ return changeDue;}
            set {changeDue = value;}
        }

        /// <summary>
        /// Amount still needed
        /// </summary>
        public double AmountDue
        {
            get 
            {
                if (CurrentPayment > 0)
                {
                    amountDue = OrderCost - CurrentPayment;
                }
                else amountDue = OrderCost;
                
                return amountDue;
            }
        }

        /// <summary>
        /// Calculates the coins needed for change
        /// </summary>
        public  void CalculateChange()
        {
            if(SufficientPayment && (CurrentPayment > OrderCost))
            {
                changeDue = Math.Round(CurrentPayment - OrderCost, 2);

                int payment = (int)changeDue;
                double paymentChange = Math.Round(changeDue - payment, 2);

                ChangeHundreds = payment / 100;
                payment %= 100;

                ChangeFifties = payment / 50;
                payment %= 50;

                ChangeTwenties = payment / 20;
                payment %= 20;

                ChangeTens = payment / 10;
                payment %= 10;

                ChangeFives = payment / 5;
                payment %= 5;

                ChangeTwos = payment / 2;
                payment %= 2;

                ChangeOnes = payment;

                ChangeDollars = 0;

                ChangeHalfDollars = (int)(paymentChange / 0.50);
                paymentChange %= 0.50;

                ChangeQuarters = (int)(paymentChange / 0.25);
                paymentChange %= 0.25;

                ChangeDimes = (int)(paymentChange / 0.10);
                paymentChange %= 0.10;

                ChangeNickels = (int)(paymentChange / 0.05);
                paymentChange %= 0.05;

                ChangePennies = (int)(paymentChange / 0.01);
            }
            else
            {
                CurrentChangeDue = 0;
                ChangeHundreds = 0;
                ChangeFifties = 0;
                ChangeTwenties = 0;
                ChangeTens = 0;
                ChangeFives = 0;
                ChangeTwos = 0;
                ChangeOnes = 0;
                ChangeDollars = 0;
                ChangeHalfDollars = 0;
                ChangeQuarters = 0;
                ChangeDimes = 0;
                ChangeNickels = 0;
                ChangePennies = 0;
            }

        }

        // CASH DRAWER----------------------------------------------------------------
        #region CashDrawer
        /// <summary>
        /// The Pennies contained within the CashDrawer
        /// </summary>
        public int Pennies
        {
            get 
            {
                
                return CashDrawer.Pennies; 
            }
            set
            {
                CashDrawer.Pennies = value;
            }
        }

        /// <summary>
        /// The Nickels contained within the CashDrawer
        /// </summary>
        public int Nickels
        {
            get
            {
                
                return CashDrawer.Nickels;
            }
            set
            {
                CashDrawer.Nickels = value;
            }
        }

        /// <summary>
        /// The Dimes contained within the CashDrawer
        /// </summary>
        public int Dimes
        {
            get
            {
                
                return CashDrawer.Dimes;
            }
            set
            {
                CashDrawer.Dimes = value;
            }
        }
        /// <summary>
        /// The Quarters contained within the CashDrawer
        /// </summary>
        public int Quarters
        {
            get
            {
                
                return CashDrawer.Quarters;
            }
            set
            {
                CashDrawer.Quarters = value;
            }
        }
        /// <summary>
        /// The Dollars contained within the CashDrawer
        /// </summary>
        public int Dollars
        {
            get
            {
                
                return CashDrawer.Dollars;
            }
            set
            {
                CashDrawer.Dollars = value;
            }
        }
        /// <summary>
        /// The HalfDollars contained within the CashDrawer
        /// </summary>
        public int HalfDollars
        {
            get
            {
                
                return CashDrawer.HalfDollars;
            }
            set
            {
                CashDrawer.HalfDollars = value;
            }
        }
        /// <summary>
        /// The Ones contained within the CashDrawer
        /// </summary>
        public int Ones
        {
            get
            {
                
                return CashDrawer.Ones;
            }
            set
            {
                CashDrawer.Ones = value;
            }
        }
        /// <summary>
        /// The Twos contained within the CashDrawer
        /// </summary>
        public int Twos
        {
            get
            {
                
                return CashDrawer.Twos;
            }
            set
            {
                CashDrawer.Twos = value;
            }
        }
        /// <summary>
        /// The Fives contained within the CashDrawer
        /// </summary>
        public int Fives
        {
            get
            {
                
                return CashDrawer.Fives;
            }
            set
            {
                CashDrawer.Fives = value;
            }
        }

        /// <summary>
        /// The Tens contained within the CashDrawer
        /// </summary>
        public int Tens
        {
            get
            {
                
                return CashDrawer.Tens;
            }
            set
            {
                CashDrawer.Tens = value;
            }
        }
        /// <summary>
        /// The Twenties contained within the CashDrawer
        /// </summary>
        public int Twenties
        {
            get
            {
                
                return CashDrawer.Twenties;
            }
            set
            {
                CashDrawer.Twenties = value;
            }
        }
        /// <summary>
        /// The Fifties contained within the CashDrawer
        /// </summary>
        public int Fifties
        {
            get
            {
                
                return CashDrawer.Fifties;
            }
            set
            {
                CashDrawer.Fifties = value;
            }
        }
        /// <summary>
        /// The Hundreds contained within the CashDrawer
        /// </summary>
        public int Hundreds
        {
            get
            {
                
                return CashDrawer.Hundreds;
            }
            set
            {
                CashDrawer.Hundreds = value;
            }
        }

        #endregion
        //------------------------------------Customer's Money-------------------------------------------------------------
        #region PaidCurrency
        /// <summary>
        /// The Pennies paid
        /// </summary>
        public int PaidPennies
        {
            get
            {
                return paidPennies;
            }
            set
            {
                paidPennies = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidPennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));

                CalculateChange();
            }
        }

        /// <summary>
        /// The Nickels paid
        /// </summary>
        public int PaidNickels
        {
            get
            {
                return paidNickels;
            }
            set
            {
                paidNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidNickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
               
                
            }
        }

        /// <summary>
        /// The Dimes paid
        /// </summary>
        public int PaidDimes
        {
            get
            {
                return paidDimes;
            }
            set
            {
                paidDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
                
            }
        }
        /// <summary>
        /// The Quarters paid
        /// </summary>
        public int PaidQuarters
        {
            get
            {
                return paidQuarters;
            }
            set
            {
                paidQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
                
            }
        }
        /// <summary>
        /// The Dollars paid
        /// </summary>
        public int PaidDollars
        {
            get
            {
                return paidDollars;
            }
            set
            {
                paidDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
                
            }
        }
        /// <summary>
        /// The HalfDollars paid
        /// </summary>
        public int PaidHalfDollars
        {
            get
            {
                return paidHalfDollars;
            }
            set
            {
                paidHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidHalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
               
            }
        }
        /// <summary>
        /// The Ones paid
        /// </summary>
        public int PaidOnes
        {
            get
            {
                return paidOnes;
            }
            set
            {
                paidOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
           
            }
        }
        /// <summary>
        /// The Twos paid
        /// </summary>
        public int PaidTwos
        {
            get
            {
                return paidTwos;
            }
            set
            {
                paidTwos= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();

            }
        }
        /// <summary>
        /// The Fives paid
        /// </summary>
        public int PaidFives
        {
            get
            {
                return paidFives;
            }
            set
            {
                paidFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
              
            }
        }

        /// <summary>
        /// The Tens paid
        /// </summary>
        public int PaidTens
        {
            get
            {
                return paidTens;
            }
            set
            {
                paidTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
              
            }
        }
        /// <summary>
        /// The Twenties paid
        /// </summary>
        public int PaidTwenties
        {
            get
            {
                return paidTwenties;
            }
            set
            {
                paidTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
               
            }
        }
        /// <summary>
        /// The Fifties paid
        /// </summary>
        public int PaidFifties
        {
            get
            {
                return paidFifties;
            }
            set
            {
                paidFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));               
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange(); 
            }
        }
        /// <summary>
        /// The Hundreds paid
        /// </summary>
        public int PaidHundreds
        {
            get
            {
                return paidHundreds;
            }
            set
            {
                paidHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();  
            }
        }
        #endregion
        //--------------Change--------------------------------------------
        #region ChangeProperties
        /// <summary>
        /// The Pennies for change
        /// </summary>
        public int ChangePennies
        {
            get
            {
                return chgPennies;   
            }
            set
            {
                chgPennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangePennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        /// The Nickels for change
        /// </summary>
        public int ChangeNickels
        {
            get
            {
                return chgNickels;
            }
            set
            {
                chgNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeNickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        /// The Dimes for change
        /// </summary>
        public int ChangeDimes
        {
            get
            {
                return chgDimes;
            }
            set
            {
                chgDimes = value;
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// The Quarters for change
        /// </summary>
        public int ChangeQuarters
        {
            get
            {
                return chgQuarters;
            }
            set
            {
                chgQuarters = value;
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
       
        /// <summary>
        /// The Dollars for change
        /// </summary>
        public int ChangeDollars
        {
            get
            {
                return chgDollars;
            }
            set
            {
                chgDollars = value;
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
                
            }
        }
        /// <summary>
        /// The HalfDollars for change
        /// </summary>
        public int ChangeHalfDollars
        {
            get
            {
                return chgHalfDollars;
            }
            set
            {
                chgHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// The Ones for change
        /// </summary>
        public int ChangeOnes
        {
            get
            {
                return chgOnes;
            }
            set
            {
                chgOnes = value;
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// The Twos for change
        /// </summary>
        public int ChangeTwos
        {
            get
            {
                return chgTwos;
            }
            set
            {
                chgTwos = value;
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// The Fives for change
        /// </summary>
        public int ChangeFives
        {
            get
            {
               return chgFives;
            }
            set
            {
                chgFives = value;
               
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        /// The Tens for change
        /// </summary>
        public int ChangeTens
        {
            get
            {
                return chgTens;
            }
            set
            {
                chgTens = value;
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// The Twenties for change
        /// </summary>
        public int ChangeTwenties
        {
            get
            {
                return chgTwenties;
            }
            set
            {
                chgTwenties = value;
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// The Fifties for change
        /// </summary>
        public int ChangeFifties
        {
            get
            {
                return chgFifties;
            }
            set
            {
                chgFifties = value;
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        /// <summary>
        /// The Hundreds for change
        /// </summary>
        public int ChangeHundreds
        {
            get
            {
                return chgHundreds;
            }
            set
            {
                chgHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }
        #endregion
        /// <summary>
        /// The Total contained within the CashDrawer
        /// </summary>
        public double Total
        {
            get
            {
                return CashDrawer.Total;
            }
        }

        /// <summary>
        /// Opens the Drawer of the register
        /// </summary>
        public void OpenDrawer()
        {
            CashDrawer.OpenDrawer();
        }

        /// <summary>
        /// Resets the drawer of the register
        /// </summary>
        public void ResetDrawer()
        {
            CashDrawer.ResetDrawer();
        }

        /// <summary>
        /// Finalizes the sale and payments
        /// </summary>
        public void FinializeSale()
        {
            Pennies = Pennies - ChangePennies + PaidPennies;
            Nickels = Nickels - ChangeNickels + PaidNickels;
            Dimes = Dimes - ChangeDimes + PaidDimes;
            Quarters = Quarters - ChangeQuarters + PaidQuarters;
            HalfDollars = HalfDollars - ChangeHalfDollars + PaidHalfDollars;
            Dollars = Dollars - ChangeDollars + PaidDollars;
            Ones = Ones - ChangeOnes + PaidOnes;
            Twos = Twos - ChangeTwos + PaidTwos;
            Fives = Fives - ChangeFives + PaidFives;
            Tens = Tens - ChangeTens + PaidTens;
            Twenties = Twenties - ChangeTwenties + PaidTwenties;
            Fifties = Fifties - ChangeFifties + PaidFifties;
            Hundreds = Hundreds - ChangeHundreds + PaidHundreds;
        }

        
    }
}
