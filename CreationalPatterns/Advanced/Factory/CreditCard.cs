using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Advanced.Factory
{
    #region Product
    public abstract class CreditCard
    {
        //The Product Abstract Class
        public abstract string CardType { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }

    }
    #endregion

    #region ConcreteProduct class

    public class MoneyBackCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "MoneyBack";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
        public override string CardType 
        {
            get => _cardType;
        }
        public override int CreditLimit 
        { 
            get => _creditLimit; 
            set => _creditLimit = value; 
        }
        public override int AnnualCharge 
        { 
            get => _annualCharge; 
            set => _annualCharge = value; 
        }
    }
    public class TitaniumCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public TitaniumCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Titanium";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
        public override string CardType 
        {
            get => _cardType;
        }
        public override int CreditLimit 
        { 
            get => _creditLimit; 
            set => _creditLimit = value; 
        }
        public override int AnnualCharge 
        { 
            get => _annualCharge; 
            set => _annualCharge = value; 
        }
    }
    public class PlantinumCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public PlantinumCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Platinum";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
        public override string CardType 
        {
            get => _cardType;
        }
        public override int CreditLimit 
        { 
            get => _creditLimit; 
            set => _creditLimit = value; 
        }
        public override int AnnualCharge 
        { 
            get => _annualCharge; 
            set => _annualCharge = value; 
        }
    }
    #endregion
}
