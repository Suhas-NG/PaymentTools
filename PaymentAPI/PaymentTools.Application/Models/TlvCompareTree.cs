﻿

using PaymentTools.Application.Services;

namespace PaymentTools.Application.Models
{
    public class TlvCompareTree
    {
        TlvBuilder tlvBuilder;
        public TlvCompareTree(Tlv? tlv1, Tlv? tlv2)
        {
            if (tlv1 != null)
            {
                tlv1Tag = tlv1.tag;
                tlv1Value = tlv1.value; 
                tlv1TagName = tlv1.tagName;
            } else
            {
                tlv1Tag = string.Empty;
                tlv1Value = string.Empty;
                tlv1TagName= string.Empty;
            }

            if (tlv2 != null)
            {
                tlv2Tag = tlv2.tag;
                tlv2Value = tlv2.value;
                tlv2TagName = tlv2.tagName;
            }
            else
            {
                tlv2Tag = string.Empty;
                tlv2Value = string.Empty;
                tlv2TagName = string.Empty;
            }
        }

        public string tlv1Tag { get; set; }
        public string tlv1TagName { get; set; } 
        public string tlv2Tag { get; set; }
        public string tlv2TagName{ get; set; }
        
        public string tlv1Value { get; set; }
        public string tlv2Value { get; set; }

        public bool HasSubTree  { get; set; }  = false;

        public string tl1Details  { get; set; }
        public string tl2Details  { get; set; }
        public List<TlvCompareTree> subTrees { get; set; }

    }
}
