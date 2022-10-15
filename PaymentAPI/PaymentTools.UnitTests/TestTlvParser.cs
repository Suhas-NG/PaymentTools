using PaymentTools.Application.Helpers;
using PaymentTools.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PaymentTools.UnitTests
{
    public class TestTlvParser
    {

        TlvParser tlvParser = new TlvParser();
        [Fact]
        public void ParseSimpleTlv()
        {
            List<Tlv> list = tlvParser.ParseHexString("4F0101");
            Assert.True(list[0].tag == "4F");
            Assert.True(list[0].value == "01");
            Assert.True(list[0].lengthValue == 1);
            Assert.True(list[0].lengthString == "01");
        } 

        [Fact]
        public void ParseNoValueTlv()
        {
            List<Tlv> list = tlvParser.ParseHexString("4F00");
            Assert.True(list[0].tag == "4F");
            Assert.True(list[0].value == "");
            Assert.True(list[0].lengthString == "00");
            Assert.True(list[0].lengthValue == 0);
        }

        [Fact]
        public void Parse2ByteTagNameTlv()
        {
            List<Tlv> list = tlvParser.ParseHexString("9F060101");
            Assert.True(list[0].tag == "9F06");
            Assert.True(list[0].value == "01");
            Assert.True(list[0].lengthString == "01");
            Assert.True(list[0].lengthValue == 1);
        }

        [Fact]
        public void TlvLowerCase()
        {
            List<Tlv> list = tlvParser.ParseHexString("9f060101");
            Assert.True(list[0].tag == "9F06");
            Assert.True(list[0].value == "01");
            Assert.True(list[0].lengthString == "01");
            Assert.True(list[0].lengthValue == 1);
        }

        [Fact]
        public void TlvNested()
        {
            List<Tlv> list = tlvParser.ParseHexString("ffee0105dfee300100");
            Assert.True(list[0].tag == "FFEE01");
            Assert.True(list[0].value == "DFEE300100");
            Assert.True(list[0].lengthString == "05");
            Assert.True(list[0].lengthValue == 5);
            Assert.True(list[0].hasNestedTlvs);
            Assert.True(list[0].nestedTlvs.Tlvs[0].tag == "DFEE30");
            Assert.True(list[0].nestedTlvs.Tlvs[0].lengthString == "01");
            Assert.True(list[0].nestedTlvs.Tlvs[0].lengthValue == 1);
            Assert.True(list[0].nestedTlvs.Tlvs[0].value == "00");
        }

        [Fact]
        public void TlvMultipleTags()
        {
            List<Tlv> list = tlvParser.ParseHexString("4f01019f06020101");
            Assert.True(list[0].tag == "4F");
            Assert.True(list[0].value == "01");
            Assert.True(list[0].lengthString == "01");
            Assert.True(list[0].lengthValue == 1);
            Assert.True(list[1].tag == "9F06");
            Assert.True(list[1].value == "0101");
            Assert.True(list[1].lengthString == "02");
            Assert.True(list[1].lengthValue == 2);
        }

        [Fact]
        public void TlvEmptyString()
        {
            List<Tlv> list = tlvParser.ParseHexString("");
            Assert.True(list.Count == 0);

        }


        [Fact]
        public void TlvWithBigValue()
        {
            List<Tlv> list = tlvParser.ParseHexString("4F81FF"+string.Concat(Enumerable.Repeat("AB", 255)));
            Assert.True(list[0].tag == "4F");
            Assert.True(list[0].value == string.Concat(Enumerable.Repeat("AB", 255)));
            Assert.True(list[0].lengthString == "81FF");
            Assert.True(list[0].lengthValue == 255);
        }

        [Fact]
        public void TlvWithVeryBigValue()
        {
            List<Tlv> list = tlvParser.ParseHexString("4F820100" + string.Concat(Enumerable.Repeat("AB", 256)));
            Assert.True(list[0].tag == "4F");
            Assert.True(list[0].value == string.Concat(Enumerable.Repeat("AB", 256)));
            Assert.True(list[0].lengthString == "820100");
            Assert.True(list[0].lengthValue == 256);
        }

        [Fact]
        public void VeryLargeTag()
        {
            try
            {
                List<Tlv> list = tlvParser.ParseHexString("DFEEEEEEEEEEEEEF0101");
            } catch (Exception ex)
            {
                Assert.True(ex.Message.Contains("Tag length above max"));
            }
        }

        [Fact]
        public void TlvWithLargeLengthAndTagName()
        {

        }

        [Fact]
        public void TLVEvenString()
        {

        }

        [Fact]
        public void DeformedTlv()
        {

        }
    }
}
