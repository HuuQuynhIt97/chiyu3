import { OcService } from './../../_core/_service/oc.service';

import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { AuthService } from '../../_core/_service/auth.service';
import { AlertifyService } from '../../_core/_service/alertify.service';
import { Router } from '@angular/router';
import { DomSanitizer } from '@angular/platform-browser';
import { CalendarsService } from 'src/app/_core/_service/calendars.service';
import * as moment from 'moment';
import { Nav } from 'src/app/_core/_model/nav';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { TranslateService } from '@ngx-translate/core';
import { RoleService } from 'src/app/_core/_service/role.service';
import { CookieService } from 'ngx-cookie-service';
import { DataService } from 'src/app/_core/_service/data.service';
import { AuthenticationService } from 'src/app/_core/_service/authentication.service';
import { NgxSpinnerService } from 'ngx-spinner';
declare var require: any;
import * as signalr from '../../../assets/js/ec-client.js';
import { HubConnectionState } from '@microsoft/signalr';
import { navItems } from 'src/app/_nav';
import { Authv2Service } from 'src/app/_core/_service/authv2.service';
import { GridComponent, SearchSettingsModel } from '@syncfusion/ej2-angular-grids';
import { FilteringEventArgs } from '@syncfusion/ej2-angular-dropdowns';
import { EmitType } from '@syncfusion/ej2-base';
import { Query } from '@syncfusion/ej2-data/';

@Component({
  selector: 'app-dashboard',
  templateUrl: './default-layout.component.html',
  styleUrls: ['default-layout.component.css']
})
export class DefaultLayoutComponent implements OnInit, AfterViewInit {
  public sidebarMinimized = false;
  public navItems = navItems;
  public navAdmin: any;
  public navClient: any;
  navEc: any;
  public total: number;
  public totalCount: number;
  public page: number;
  public pageSize: number;
  public currentUser: string;
  public currentTime: any;
  userid: number;
  level: number;
  roleName: string;
  role: any;
  avatar: any;
  vi: any;
  en: any;
  langsData: object[];
  public fields = { text: 'name', value: 'id' };
  public value: string;
  zh: any;
  menus: any;
  modalReference: any;

  online: number;
  userID: number;
  userName: any;
  data: any;
  firstItem: any;
  toolbarOptions = ['Search','ExcelExport'];
  pageSettings = { pageCount: 20, pageSizes: true, pageSize: 20 };
  @ViewChild('ingredientinfoGrid') grid: GridComponent;
  filterSettings = { type: 'Excel' };
  buildings: any;
  fieldsBuildings: object = { text: 'name', value: 'id' };
  buildingID: any
  startDate: Date;
  endDate: Date;
  public searchOptions: SearchSettingsModel;
  constructor(
    private authService: AuthService,
    private authenticationService: Authv2Service,
    private roleService: RoleService,
    private alertify: AlertifyService,
    private calendarsService: CalendarsService,
    private sanitizer: DomSanitizer,
    private router: Router,
    private dataService: DataService,
    private ocService: OcService,
    private spinner: NgxSpinnerService,
    private cookieService: CookieService,
    private modalService: NgbModal,
    public translate: TranslateService

  ) {
    this.vi = require('../../../assets/ej2-lang/vi.json');
    this.en = require('../../../assets/ej2-lang/en.json');

  }
  toggleMinimize(e) {
    this.sidebarMinimized = e;
  }
  ngOnInit(): void {
    this.endDate = new Date();
    this.startDate = new Date();
    this.searchOptions = {
      fields: [
        'guestID',
        'cardNo',
        'guestName',

      ],
      operator: 'contains',
      ignoreCase: true,
    };
    this.getAllGroup();
    this.page = 1;
    this.pageSize = 20;

    this.currentTime = moment().format('hh:mm:ss A');
    setInterval(() => this.updateCurrentTime(), 1 * 1000);
  }

  createdSearch(args) {
    var gridElement = this.grid.element;
    var span = document.createElement("span");
    span.className = "e-clear-icon";
    span.id = gridElement.id + "clear";
    span.onclick = this.cancelBtnClick.bind(this);
    gridElement.querySelector(".e-toolbar-item .e-input-group").appendChild(span);
  }

  public cancelBtnClick(args) {
    this.grid.searchSettings.key = "";
    (this.grid.element.querySelector(".e-input-group.e-search .e-input") as any).value = "";
  }

  ngAfterViewInit() {
    // this.getBuilding();
  }
  getResultByGroup() {
    this.ocService.getResultByGroup(this.buildingID , this.startDate.toDateString(), this.endDate.toDateString()).subscribe(res => {
      this.data = res
      this.spinner.hide();
    })
  }
  getAllGroup() {
    this.ocService.getAllGroup().subscribe(res => {
      this.buildings = res
    })
  }
  startDateOnchange(args) {
    this.spinner.show()
    this.startDate = (args.value as Date);
    this.getResultByGroup()
  }

  endDateOnchange(args) {
    this.spinner.show()
    this.endDate = (args.value as Date);
    this.getResultByGroup()

  }
  onClickDefault() {
    this.spinner.show()
    this.startDate = new Date();
    this.endDate = new Date();
    this.getResultByGroup()
  }
  onChangeBuilding(args) {
    this.spinner.show()
    // localStorage.setItem('buildingID', this.buildingID + '');
    this.buildingID = args.itemData.id;
    // this.buildingName = args.itemData.name;
    this.getResultByGroup();

  }

  onFilteringBuilding: EmitType<FilteringEventArgs> = (
    e: FilteringEventArgs
  ) => {
    let query: Query = new Query();
    // frame the query based on search string with filter type.
    query =
      e.text !== '' ? query.where('name', 'contains', e.text, true) : query;
    // pass the filter data source, filter query to updateData method.
    e.updateData(this.buildings as any, query as any);
  }

  toolbarClick(args): void {
    console.log(args.item.text);
    switch (args.item.text) {
      /* tslint:disable */
      case 'Excel Export':
        this.grid.excelExport();
        break;
      /* tslint:enable */
      case 'PDF Export':
        break;
    }
  }
  dataBound() {
    this.grid.autoFitColumns();
  }



  getBuilding() {
    const userID = JSON.parse(localStorage.getItem('user')).user.id;
    this.roleService.getRoleByUserID(userID).subscribe((res: any) => {
      res = res || {};
      if (res !== {}) {
        this.level = res.id;
      }
    });
  }


  updateCurrentTime() {
    this.currentTime = moment().format('hh:mm:ss A');
  }
  logout() {
    this.cookieService.deleteAll();
    localStorage.clear();
    this.authService.decodedToken = null;
    this.authService.currentUser = null;
    this.authenticationService.logOut();
    const uri = this.router.url;
    this.router.navigate(['login'], { queryParams: { uri }, replaceUrl: true });
    this.alertify.message('Logged out');

  }

  defaultImage() {
    return this.sanitizer.bypassSecurityTrustResourceUrl(`data:image/png;base64, iVBORw0KGgoAAAANSUhEUgAAAJYAA
      ACWBAMAAADOL2zRAAAAG1BMVEVsdX3////Hy86jqK1+ho2Ql521ur7a3N7s7e5Yhi
      PTAAAACXBIWXMAAA7EAAAOxAGVKw4bAAABAElEQVRoge3SMW+DMBiE4YsxJqMJtH
      OTITPeOsLQnaodGImEUMZEkZhRUqn92f0MaTubtfeMh/QGHANEREREREREREREtIJ
      J0xbH299kp8l8FaGtLdTQ19HjofxZlJ0m1+eBKZcikd9PWtXC5DoDotRO04B9YOvF
      IXmXLy2jEbiqE6Df7DTleA5socLqvEFVxtJyrpZFWz/pHM2CVte0lS8g2eDe6prOy
      qPglhzROL+Xye4tmT4WvRcQ2/m81p+/rdguOi8Hc5L/8Qk4vhZzy08DduGt9eVQyP
      2qoTM1zi0/uf4hvBWf5c77e69Gf798y08L7j0RERERERERERH9P99ZpSVRivB/rgAAAABJRU5ErkJggg==`);
  }
  getAvatar() {
    const img = localStorage.getItem('avatar');
    if (img === 'null') {
      this.avatar = this.defaultImage();
    } else {
      this.avatar = this.sanitizer.bypassSecurityTrustResourceUrl('data:image/png;base64, ' + img);
    }
  }
  imageBase64(img) {
    if (img === 'null') {
      return this.defaultImage();
    } else {
      return this.sanitizer.bypassSecurityTrustResourceUrl('data:image/png;base64, ' + img);
    }
  }
  datetime(d) {
    return this.calendarsService.JSONDateWithTime(d);
  }

  openModal(ref) {
    this.modalReference = this.modalService.open(ref, { size: 'xl', backdrop: 'static', keyboard: false });

  }
}
