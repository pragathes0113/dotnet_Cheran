using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VHMS.Entity
{
    public class Rate
    {
        public int RateID { get; set; }
        public Agent Agent { get; set; }
        public int AgentID { get; set; }
        public string RateName { get; set; }
        public decimal FoodAllowance { get; set; }
        public decimal PipeDeapthRate { get; set; }
        public decimal TransportRate { get; set; }
        public decimal WeldingRate { get; set; }
        public decimal Threehundred { get; set; }
        public decimal ThreehundredAmount { get; set; }
        public decimal Fourhundred { get; set; }
        public decimal FourhundredAmount { get; set; }
        public decimal Fivehundred { get; set; }
        public decimal FivehundredAmount { get; set; }
        public decimal Sixhundred { get; set; }
        public decimal SixhundredAmount { get; set; }
        public decimal Sevenhundred { get; set; }
        public decimal SevenhundredAmount { get; set; }
        public decimal Eighthundred { get; set; }
        public decimal EighthundredAmount { get; set; }
        public decimal Ninehundred { get; set; }
        public decimal NinehundredAmount { get; set; }
        public decimal Onethousand { get; set; }
        public decimal OnethousandAmount { get; set; }
        public decimal OneThousandOneHundred { get; set; }
        public decimal OneThousandOneHundredAmount { get; set; }
        public decimal OneThousandTwoHundred { get; set; }
        public decimal OneThousandTwoHundredAmount { get; set; }
        public decimal OneThousandThreeHundred { get; set; }
        public decimal OneThousandThreeHundredAmount { get; set; }
        public decimal OneThousandFourHundred { get; set; }
        public decimal OneThousandFourHundredAmount { get; set; }
        public decimal OneThousandFiveHundred { get; set; }
        public decimal OneThousandFiveHundredAmount { get; set; }
        public decimal OneThousandSixHundred { get; set; }
        public decimal OneThousandSixHundredAmount { get; set; }
        public decimal OneThousandSevenHundred { get; set; }
        public decimal OneThousandSevenHundredAmount { get; set; }
        public decimal OneThousandEightHundred { get; set; }
        public decimal OneThousandEightHundredAmount { get; set; }
        public decimal OneThousandNineHundred { get; set; }
        public decimal OneThousandNineHundredAmount { get; set; }
        public decimal TwoThousand { get; set; }
        public decimal TwoThousandAmount { get; set; }
        public decimal TwoThousandOneHundred { get; set; }
        public decimal TwoThousandOneHundredAmount { get; set; }
        public decimal TwoThousandTwoHundred { get; set; }
        public decimal TwoThousandTwoHundredAmount { get; set; }
        public decimal TwoThousandThreeHundred { get; set; }
        public decimal TwoThousandThreeHundredAmount { get; set; }
        public decimal TwoThousandFourHundred { get; set; }
        public decimal TwoThousandFourHundredAmount { get; set; }
        public decimal TwoThousandFiveHundred { get; set; }
        public decimal TwoThousandFiveHundredAmount { get; set; }
        public decimal TwoThousandSixHundred { get; set; }
        public decimal TwoThousandSixHundredAmount { get; set; }
        public decimal TwoThousandSevenHundred { get; set; }
        public decimal TwoThousandSevenHundredAmount { get; set; }
        public decimal TwoThousandEightHundred { get; set; }
        public decimal TwoThousandEightHundredAmount { get; set; }
        public decimal TwoThousandNineHundred { get; set; }
        public decimal TwoThousandNineHundredAmount { get; set; }
        public User CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public User ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }

}