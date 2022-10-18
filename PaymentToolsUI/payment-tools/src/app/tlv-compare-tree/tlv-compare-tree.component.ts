import { Component, Input, OnInit } from '@angular/core';
import { ITlvCompare } from '../tlv-comparer/tlv-compare';

@Component({
  selector: 'app-tlv-compare-tree',
  templateUrl: './tlv-compare-tree.component.html',
  styleUrls: ['./tlv-compare-tree.component.css']
})
export class TlvCompareTreeComponent implements OnInit {

  @Input() TlvCompareResults : ITlvCompare[]=[] ;
  constructor() { }

  SubTreeBtnText = "+"
  SubTreeVisisble = false
  onSubTreeExpandClick() {
    if (this.SubTreeBtnText == "+"){
      this.SubTreeBtnText = "-"
      this.SubTreeVisisble = true
    } else {
      this.SubTreeBtnText = "+"
      this.SubTreeVisisble = false
    }
  }

  ngOnInit(): void {
  }

}
