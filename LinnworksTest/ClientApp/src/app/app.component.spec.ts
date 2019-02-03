import { HttpClient } from '@angular/common/http';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { TestBed } from '@angular/core/testing';
import { Data, Router } from '@angular/router';
import { CookieService } from 'ngx-cookie-service';
import { LoginComponent } from './login/login.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';


/*
 * A simple unit test
 */
describe('Sample Test', () => {
  it('A sample karma-jasmine test that should always pass to verify the configuration.', () => {

    expect("LINNWORKS").toBe("LINNWORKS");
  });
});


/*
 * Unit tests for Login Components
 */

describe('Test Login Component: (isolated test)', () => {
  let _http: HttpClient;
  let _router: Router;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [LoginComponent]
    });
  });

  it('It should instantiate', () => {
    const component: LoginComponent = new LoginComponent(_http, _router);
    expect(component).toBeDefined();
  });

  it('It should has a Boolean property `isRequesting`', () => {
    const component: LoginComponent = new LoginComponent(_http, _router);
    component.isRequesting = true;
    expect(component.isRequesting).toEqual(jasmine.any(Boolean));
    expect(component.isRequesting).toBe(true);
  });

  it('It should has a String property `token`', () => {
    const component: LoginComponent = new LoginComponent(_http, _router);
    component.token = "bccf905c - 6592 - 40f2 - 8db1 - c976791fa40a";
    expect(component.token).toEqual(jasmine.any(String));
  });

});


/*
 * Unit tests for nav-menu Components
 */

describe('Test nav-menu Component: (isolated test)', () => {
  let _cookie: CookieService;
  let _router: Router;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NavMenuComponent]
    });
  });

  it('It should instantiate', () => {
    const component: NavMenuComponent = new NavMenuComponent(_cookie, _router);
    expect(component).toBeDefined();
  });

  it('It should be able to invoke and test `collapse()` method', () => {
    const component: NavMenuComponent = new NavMenuComponent(_cookie, _router);

    expect(component.isExpanded).toEqual(jasmine.any(Boolean));

    component.isExpanded = true;
    component.collapse();
    expect(component.isExpanded).toBe(false);

   
  });

  it('It should be able to invoke and test `toggle()` method', () => {
    const component: NavMenuComponent = new NavMenuComponent(_cookie, _router);
    component.toggle();
    expect(component.isExpanded).toBe(true);
  });

});


/*
 * Below code snippet is for implementing more unit tests to verify the functionality of various components.
 *
 */

//describe('HttpClient testing', () => {
//  let httpClient: HttpClient;
//  let httpTestingController: HttpTestingController;

//  beforeEach(() => {
//    TestBed.configureTestingModule({
//      imports: [HttpClientTestingModule]
//    });

   
//    httpClient = TestBed.get(HttpClient);
//    httpTestingController = TestBed.get(HttpTestingController);
//  });

//  /// Tests begin ///
//  it('can test HttpClient.get', () => {
//    const testData: Data = { name: 'Test Data' };

//    httpClient.get<Data>("http://localhost:4200/")
//      .subscribe(data =>
//        expect(data).toEqual(testData)
//      );

//    const req = httpTestingController.expectOne('/data');

//    expect(req.request.method).toEqual('GET');
//    req.flush(testData);
//    httpTestingController.verify();
//  });
//});

//describe('Component: Login', () => {

//  let component: LoginComponent;
//  let fixture: ComponentFixture<LoginComponent>;
//  let submitEl: DebugElement;
//  let loginEl: DebugElement;
//  let passwordEl: DebugElement;

//  beforeEach(() => {

//    TestBed.configureTestingModule({
//      declarations: [LoginComponent]
//    }).compileComponents().then(() => {
//      // create component and test fixture
//      fixture = TestBed.createComponent(LoginComponent);

//      // get test component from the fixture
//      component = fixture.componentInstance;
//    });

   

//    submitEl = fixture.debugElement.query(By.css('button'));
//    loginEl = fixture.debugElement.query(By.css('input[type=text]'));
//    passwordEl = fixture.debugElement.query(By.css('label[for=token]'));
//  });

//  it('Setting isRequesting to true disables the submit button', () => {
//    component.isRequesting = true;
//  });
//});

  //function tests() {
  //  let linkDes: DebugElement[];
  //  let routerLinks: RouterLinkDirectiveStub[];

  //  beforeEach(() => {
  //    fixture.detectChanges();

  //    // find DebugElements with an attached RouterLinkStubDirective
  //    //linkDes = fixture.debugElement
  //     // .queryAll(By.directive(RouterLinkDirectiveStub));

  //    // get attached link directive instances
  //    // using each DebugElement's injector
  //   // routerLinks = linkDes.map(de => de.injector.get(RouterLinkDirectiveStub));
  //  });

  //  it('can instantiate the component.', () => {
  //    expect(comp).not.toBeNull();
  //  });
  //}

