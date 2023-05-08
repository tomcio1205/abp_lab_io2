import { LABIOTemplatePage } from './app.po';

describe('LABIO App', function() {
  let page: LABIOTemplatePage;

  beforeEach(() => {
    page = new LABIOTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
