using PaymentTools.Application.Helpers;
using PaymentTools.Application.Models;
using System.Collections.Generic;
using Xunit;

namespace PaymentTools.UnitTests
{
    public class TlvCompareTest
    {

        [Fact]
        public void testCompareTlvSameTag()
        {
            string tlvList1 = "4f0101";
            string tlvList2 = "4f0102";
            TlvCompare tlvCompare = new TlvCompare();
            TlvParser tlvParser = new TlvParser();
            List<Tlv> tlvs1 = tlvParser.ParseHexString(tlvList1);
            List<Tlv> tlvs2 = tlvParser.ParseHexString(tlvList2);
            List<TlvCompareTree> compareResult = tlvCompare.ComparerTlvCollection( tlvs1, tlvs2);
            Assert.True(compareResult.Count == 1 );
            Assert.True(compareResult[0].tlv1Tag == "4F" );
            Assert.True(compareResult[0].tlv1Value == "01" );
            Assert.True(compareResult[0].tlv2Tag == "4F" );
            Assert.True(compareResult[0].tlv2Value == "02" );
        }

        [Fact]
        public void testCompareTlvDifferentTags()
        {
            string tlvList1 = "4f0101";
            string tlvList2 = "9f060102";
            TlvCompare tlvCompare = new TlvCompare();
            TlvParser tlvParser = new TlvParser();
            List<Tlv> tlvs1 = tlvParser.ParseHexString(tlvList1);
            List<Tlv> tlvs2 = tlvParser.ParseHexString(tlvList2);
            List<TlvCompareTree> compareResult = tlvCompare.ComparerTlvCollection(tlvs1, tlvs2);
            Assert.True(compareResult.Count == 2);
            Assert.True(compareResult[0].tlv1Tag == "4F");
            Assert.True(compareResult[0].tlv1Value == "01");
            Assert.True(compareResult[1].tlv2Tag == "9F06");
            Assert.True(compareResult[1].tlv2Value == "02");
        }

        [Fact]
        public void testCompareTlvOneTagSameTag()
        {
            string tlvList1 = "4f0101";
            string tlvList2 = "9f0601024f0101";
            TlvCompare tlvCompare = new TlvCompare();
            TlvParser tlvParser = new TlvParser();
            List<Tlv> tlvs1 = tlvParser.ParseHexString(tlvList1);
            List<Tlv> tlvs2 = tlvParser.ParseHexString(tlvList2);
            List<TlvCompareTree> compareResult = tlvCompare.ComparerTlvCollection(tlvs1, tlvs2);
            Assert.True(compareResult.Count == 2);
            Assert.True(compareResult[0].tlv1Tag == "4F");
            Assert.True(compareResult[0].tlv1Value == "01");
            Assert.True(compareResult[0].tlv2Tag == "4F");
            Assert.True(compareResult[0].tlv2Value == "01");
            Assert.True(compareResult[1].tlv1Tag == "");
            Assert.True(compareResult[1].tlv1Value == "");
            Assert.True(compareResult[1].tlv2Tag == "9F06");
            Assert.True(compareResult[1].tlv2Value == "02");
        }

        [Fact]
        public void testCompareTlvOneTagDifferentTagValue()
        {
            string tlvList1 = "4f0101";
            string tlvList2 = "9f0601024f020990";
            TlvCompare tlvCompare = new TlvCompare();
            TlvParser tlvParser = new TlvParser();
            List<Tlv> tlvs1 = tlvParser.ParseHexString(tlvList1);
            List<Tlv> tlvs2 = tlvParser.ParseHexString(tlvList2);
            List<TlvCompareTree> compareResult = tlvCompare.ComparerTlvCollection(tlvs1, tlvs2);
            Assert.True(compareResult.Count == 2);
            Assert.True(compareResult[0].tlv1Tag == "4F");
            Assert.True(compareResult[0].tlv1Value == "01");
            Assert.True(compareResult[0].tlv2Tag == "4F");
            Assert.True(compareResult[0].tlv2Value == "0990");
            Assert.True(compareResult[1].tlv1Tag == "");
            Assert.True(compareResult[1].tlv1Value == "");
            Assert.True(compareResult[1].tlv2Tag == "9F06");
            Assert.True(compareResult[1].tlv2Value == "02");
        }


        [Fact]
        public void testCompareTlvCompletelyDifferentTags()
        {
            string tlvList1 = "4f01019f330109";
            string tlvList2 = "9f06010284020990";
            TlvCompare tlvCompare = new TlvCompare();
            TlvParser tlvParser = new TlvParser();
            List<Tlv> tlvs1 = tlvParser.ParseHexString(tlvList1);
            List<Tlv> tlvs2 = tlvParser.ParseHexString(tlvList2);
            List<TlvCompareTree> compareResult = tlvCompare.ComparerTlvCollection(tlvs1, tlvs2);
            Assert.True(compareResult.Count == 4);
            Assert.True(compareResult[0].tlv1Tag == "4F");
            Assert.True(compareResult[0].tlv1Value == "01");
            Assert.True(compareResult[0].tlv2Tag == "");
            Assert.True(compareResult[0].tlv2Value == "");
            Assert.True(compareResult[1].tlv1Tag == "9F33");
            Assert.True(compareResult[1].tlv1Value == "09");
            Assert.True(compareResult[1].tlv2Tag == "");
            Assert.True(compareResult[1].tlv2Value == "");
        }

        [Fact]
        public void testCompareNestedTags()
        {
            string tlvList1 = "ffee0105dfee300100";
            string tlvList2 = "ffee0105dfee300102";
            TlvCompare tlvCompare = new TlvCompare();
            TlvParser tlvParser = new TlvParser();
            List<Tlv> tlvs1 = tlvParser.ParseHexString(tlvList1);
            List<Tlv> tlvs2 = tlvParser.ParseHexString(tlvList2);
            List<TlvCompareTree> compareResult = tlvCompare.ComparerTlvCollection(tlvs1, tlvs2);
            Assert.True(compareResult.Count == 1);
            Assert.True(compareResult[0].tlv1Tag == "FFEE01");
            Assert.True(compareResult[0].tlv1Value == "DFEE300100");
            Assert.True(compareResult[0].tlv2Tag == "FFEE01");
            Assert.True(compareResult[0].tlv2Value == "DFEE300102");
            Assert.True(compareResult[0].subTrees[0].tlv1Tag == "DFEE30");
            Assert.True(compareResult[0].subTrees[0].tlv1Value == "00");
            Assert.True(compareResult[0].subTrees[0].tlv2Tag == "DFEE30");
            Assert.True(compareResult[0].subTrees[0].tlv2Value == "02");
        }

    }
}
