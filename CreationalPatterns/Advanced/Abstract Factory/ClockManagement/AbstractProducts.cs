using System;

namespace CreationalPatterns.Advanced.Abstract_Factory.ClockManagement
{
    /*
     * How to generate constructor: 
     * URL: https://docs.microsoft.com/en-us/visualstudio/ide/reference/generate-constructor?view=vs-2022
     */
    public abstract class AbstractProducts
    {
        public string name { get; set; }
        public string ID { get; set; }
        public string Gender { get; set; }
        public string CaseSize { get; set; }
        public string GlassType { get; set; }
        public string WatchDisplay { get; set; }
        public string StrapWidth { get; set; }
        public string Strap { get; set; }
        public string CaseThickness { get; set; }
        public string MovementType { get; set; }
        public string WaterResitance { get; set; }
        public string Collection { get; set; }
        public string MadeIn { get; set; }
        public string Branch { get; set; }
        public string CompanyOrIncorporate { get; set; }
        public int StockKeepingUnit { get; set; } = 0;

        public AbstractProducts()
        {

        }
        public AbstractProducts(string iD, string gender,
            string caseSize, string glassType,
            string watchDisplay, string strapWidth,
            string strap, string caseThickness,
            string movementType, string waterResitance,
            string collection, string madeIn,
            string branch, string companyOrIncorporate,
            int stockKeepingUnit)
        {
            ID = iD;
            Gender = gender;
            CaseSize = caseSize;
            GlassType = glassType;
            WatchDisplay = watchDisplay;
            StrapWidth = strapWidth;
            Strap = strap;
            CaseThickness = caseThickness;
            MovementType = movementType;
            WaterResitance = waterResitance;
            Collection = collection;
            MadeIn = madeIn;
            Branch = branch;
            CompanyOrIncorporate = companyOrIncorporate;
            StockKeepingUnit = stockKeepingUnit;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {ID}\nName: {name}\nGender: {Gender}" +
                $"\nCase Size: {CaseSize}\nGlass Type: {GlassType}\nWatch Display: {WatchDisplay}" +
                $"\nStrap Width: {StrapWidth}\nStrap: {Strap}\nCase Thickness: {CaseThickness}" +
                $"\nMovement Type: {MovementType}\nWater Resitance: {WaterResitance}" +
                $"\nCollection: {Collection}\nMade in: {MadeIn}\nBranch: {Branch}" +
                $"\nCompany/Incorporate: {CompanyOrIncorporate}\nStock Keeping Unit: {StockKeepingUnit}\n");
        }
    }

    public interface IAnalogWatches
    {
        void GetWatchesDetail();
    }

    public interface IDigitalWatches
    {
        void GetWatchesDetail();
    }

    public class CasioMTP : AbstractProducts, IAnalogWatches
    {
        public CasioMTP()
        {
            name = "MTP-E321B-1AVDF";
        }

        public CasioMTP(string iD, string gender,
            string caseSize, string glassType,
            string watchDisplay, string strapWidth,
            string strap, string caseThickness,
            string movementType, string waterResitance,
            string collection, string madeIn,
            string branch, string companyOrIncorporate,
            int stockKeepingUnit)
            : base(iD, gender, caseSize, glassType, watchDisplay,
                strapWidth, strap, caseThickness,
                movementType, waterResitance, collection,
                madeIn, branch, companyOrIncorporate, stockKeepingUnit)
        {

        }

        public void GetWatchesDetail()
        => base.Display();
    }

    public class WomanSkmei : AbstractProducts, IAnalogWatches
    {
        public WomanSkmei()
        {
            name = "Skmei SK-1220 Bạc";
        }

        public WomanSkmei(string iD, string gender,
            string caseSize, string glassType,
            string watchDisplay, string strapWidth,
            string strap, string caseThickness,
            string movementType, string waterResitance,
            string collection, string madeIn,
            string branch, string companyOrIncorporate,
            int stockKeepingUnit)
            : base(iD, gender, caseSize, glassType, watchDisplay,
                strapWidth, strap, caseThickness,
                movementType, waterResitance, collection,
                madeIn, branch, companyOrIncorporate, stockKeepingUnit)
        {

        }

        public void GetWatchesDetail()
        => base.Display();
    }

    public class ChildSkmei : AbstractProducts, IDigitalWatches
    {
        public ChildSkmei()
        {
            name = "Skmei 1484BURD";
        }

        public ChildSkmei(string iD, string gender,
            string caseSize, string glassType,
            string watchDisplay, string strapWidth,
            string strap, string caseThickness,
            string movementType, string waterResitance,
            string collection, string madeIn,
            string branch, string companyOrIncorporate,
            int stockKeepingUnit)
            : base(iD, gender, caseSize, glassType, watchDisplay,
                strapWidth, strap, caseThickness,
                movementType, waterResitance, collection,
                madeIn, branch, companyOrIncorporate, stockKeepingUnit)
        {

        }

        public void GetWatchesDetail()
        => base.Display();
    }
    public class CasioAE : AbstractProducts, IDigitalWatches
    {
        public CasioAE()
        {
            name = "AE-1000W-1AVDF";
        }

        public CasioAE(string iD, string gender,
            string caseSize, string glassType,
            string watchDisplay, string strapWidth,
            string strap, string caseThickness,
            string movementType, string waterResitance,
            string collection, string madeIn,
            string branch, string companyOrIncorporate,
            int stockKeepingUnit)
            : base(iD, gender, caseSize, glassType, watchDisplay,
                strapWidth, strap, caseThickness,
                movementType, waterResitance, collection,
                madeIn, branch, companyOrIncorporate, stockKeepingUnit)
        {

        }

        public void GetWatchesDetail()
        => base.Display();
    }


}
