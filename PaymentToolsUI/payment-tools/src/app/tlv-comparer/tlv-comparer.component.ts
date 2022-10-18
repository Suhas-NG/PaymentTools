import { Component, Input } from '@angular/core';
import { ITlvCompare } from './tlv-compare';
import { TlvCompareService } from './tlv-compare-service';


@Component({
  selector: 'app-tlv-comparer',
  templateUrl: './tlv-comparer.component.html',
  styleUrls: ['./tlv-comparer.component.css']
})
export class TlvComparerComponent {
  public tlvInput1 = "4f0101ffee0105dfee3001009f330FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"
  public tlvInput2 = "4f020102"
  public treeContainerVisible = false

  constructor(private tlvCompareService: TlvCompareService) { }

  public tlvCompareResults : ITlvCompare[]=[] ;
  public errorMessage = "";
  public onCompare() {
      this.treeContainerVisible = true
      this.tlvCompareService.getTlvCompareResult(this.tlvInput1, this.tlvInput2).subscribe({
      next : tlvCompareResults => this.tlvCompareResults = tlvCompareResults,
      error : err => this.errorMessage = err
    });
  }

}
