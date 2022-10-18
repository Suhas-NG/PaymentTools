
using PaymentTools.Application.Services;

namespace PaymentTools.Application.Models
{
    public class TlvCompare
    {
        private  TlvBuilder _tlvBuilder = new TlvBuilder();
        public List<TlvCompareTree> ComparerTlvCollection( List<Tlv> tlvs1, List<Tlv> tlvs2 )
        {
            List<TlvCompareTree> tlvCompareTrees = new List<TlvCompareTree>();
            bool tc1Present = tlvs1.Count > 0;
            bool tc2Present = tlvs2.Count > 0;

            HashSet<string> tagNames = new HashSet<string>();

            if ( tc1Present )
            tlvs1.ForEach(
                u => tagNames.Add(u.tag));

            if ( tc2Present )
            tlvs2.ForEach(
                u => tagNames.Add(u.tag));


            foreach(var tag in tagNames )
            {
                Tlv tlv1 = _tlvBuilder.BuildEmptyTlv();
                Tlv tlv2 = _tlvBuilder.BuildEmptyTlv();
                if (tc1Present )
                {
                    tlv1 = tlvs1.FirstOrDefault(u => u.tag == tag) ?? _tlvBuilder.BuildEmptyTlv();
                }
                if (tc2Present)
                {
                    tlv2 = tlvs2.FirstOrDefault(u => u.tag == tag) ?? _tlvBuilder.BuildEmptyTlv();
                }

                TlvCompareTree tree = new TlvCompareTree(tlv1, tlv2);

                var nestedTlv1 = new List<Tlv>();
                var nestedTlv2 = new List<Tlv>();
                bool hasSubStree = false;
                if(tc1Present && tlv1.hasNestedTlvs)
                {
                    nestedTlv1 = tlv1.nestedTlvs.Tlvs;
                    hasSubStree = true;
                }
                if(tc2Present && tlv2.hasNestedTlvs)
                {
                    nestedTlv2 = tlv2.nestedTlvs.Tlvs;
                    hasSubStree = true;
                }

                if (hasSubStree)
                {
                    tree.subTrees = ComparerTlvCollection(nestedTlv1, nestedTlv2);
                    tree.HasSubTree = hasSubStree;
                }
                tlvCompareTrees.Add(tree);                    
            }

            return tlvCompareTrees;
        }

    }
}
