export interface ITlvCompare {
    tlv1Tag: string;
    tlv2Tag: string;
    tlv1Value: string;
    tlv2Value: string;
    hasSubTree: string;
    subTrees: ITlvCompare[];
}