//
//  AddressDetailController.m
//  mobile-application
//
//  Created by Nghia, Nguyen Dinh Gia on 5/8/14.
//  Copyright (c) 2014 Nghia, Nguyen Dinh Gia. All rights reserved.
//

#import "AddressDetailController.h"
#import "AddressDetailCell.h"
#import <QuartzCore/QuartzCore.h>

@interface AddressDetailController ()

@end

@implementation AddressDetailController

- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil
{
    self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil];
    if (self) {
        // Custom initialization
    }
    return self;
}

- (void)viewDidLoad
{
    [super viewDidLoad];
    // Do any additional setup after loading the view from its nib.
    
    // init section name
    sectionName = [[NSMutableArray alloc] initWithObjects:@"Address", @"Phone", nil];
    self.tblAddress.backgroundColor = [UIColor clearColor];
    //self.tblAddress.backgroundView.hidden = YES;
    //self.tblAddress.layer.borderWidth = 2;
    //self.tblAddress.layer.borderColor = [[UIColor whiteColor] CGColor];
    //[self.tblAddress setSeparatorInset:UIEdgeInsetsZero];
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

-(NSInteger)numberOfSectionsInTableView:(UITableView *)tableView
{
    return [sectionName count];
}

-(NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section
{
    return 1;
}

-(void)tableView:(UITableView *)tableView didSelectRowAtIndexPath:(NSIndexPath *)indexPath
{
    
}

//-(void)resizeTableView
//{
//	UITableView *theTableView = self.tblViewListMap;
//	CGFloat newWidth = 200;
//
//	//Change the width of a table view
//	CGRect tableViewFrame = theTableView.frame;
//	tableViewFrame.size.width = newWidth;
//	theTableView.frame = tableViewFrame;
//
//	//Walk the subviews of the table view and change their width
//	CGRect cellFrame;
//	for (UITableViewCell *cell in theTableView.subviews)
//	{
//
//        if (![cell isMemberOfClass:[UITableViewCell class]]) continue;
//		cellFrame = cell.frame;
//		cellFrame.size.height = 74;
//        cellFrame.size.width = 320;
//		cell.frame = cellFrame;
//	}
//}

-(CGFloat)tableView:(UITableView *)tableView heightForRowAtIndexPath:(NSIndexPath *)indexPath
{
    //    // Get the text so we can measure it
    //    NSString *text = [items objectAtIndex:[indexPath row]];
    //    // Get a CGSize for the width and, effectively, unlimited height
    //    CGSize constraint = CGSizeMake(CELL_CONTENT_WIDTH - (CELL_CONTENT_MARGIN * 2), 20000.0f);
    //    // Get the size of the text given the CGSize we just made as a constraint
    //    CGSize size = [text sizeWithFont:[UIFont systemFontOfSize:FONT_SIZE] constrainedToSize:constraint lineBreakMode:UILineBreakModeWordWrap];
    //    // Get the height of our measurement, with a minimum of 44 (standard cell size)
    //    CGFloat height = MAX(size.height, 44.0f);
    //    // return the height, with a bit of extra padding in
    //    return height + (CELL_CONTENT_MARGIN * 2);
    return 90;
}

-(UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath
{
    static NSString *addressCell = @"AddressDetailCell";
    AddressDetailCell *cell = (AddressDetailCell *)[tableView dequeueReusableCellWithIdentifier:addressCell];
    if(cell == nil){
        NSArray *nib = [[NSBundle mainBundle] loadNibNamed:addressCell owner:self options:nil];
        cell = [nib objectAtIndex:0];
    }
    
    if(indexPath.section == 0)
    {
        cell.lblFullAddress.text = @"Full Address Is Here";
        cell.lblFullAddress.adjustsFontSizeToFitWidth = YES;
        [cell.imagePath setImage:[UIImage imageNamed:@"map"]];
        cell.lblType.text = @"Direction";
        cell.type = 1;
    }
    else
    {
        cell.lblFullAddress.text = @"Phone Number Here";
        cell.lblFullAddress.adjustsFontSizeToFitWidth = YES;
        [cell.imagePath setImage:[UIImage imageNamed:@"call"]];
        cell.lblType.text = @"Call";
        cell.type = 2;
    }
    [cell setSelectionStyle:UITableViewCellSelectionStyleNone];
    CALayer* layer = cell.layer;
    [layer setCornerRadius:8.0f];
    [layer setMasksToBounds:YES];
    [layer setBorderWidth:1.0f];
    
    return cell;
}

-(NSString *)tableView:(UITableView *)tableView titleForHeaderInSection:(NSInteger)section
{
    return [sectionName objectAtIndex:section];
}

- (IBAction)btnBackTouch:(id)sender {
     [self dismissViewControllerAnimated:YES completion:nil];
}

- (UIView *)tableView:(UITableView *)tableView viewForHeaderInSection:(NSInteger)section
{
    UIView *sectionHeaderView = [[UIView alloc] initWithFrame:
                                 CGRectMake(0, 0, tableView.frame.size.width, 50.0)];
    //sectionHeaderView.backgroundColor = [UIColor cyanColor];
    
    UILabel *headerLabel = [[UILabel alloc] initWithFrame:
                            CGRectMake(0, 0, sectionHeaderView.frame.size.width, 25.0)];
    
    headerLabel.backgroundColor = [UIColor clearColor];
    headerLabel.textAlignment = NSTextAlignmentLeft;
    [sectionHeaderView addSubview:headerLabel];
    
    headerLabel.text = [sectionName objectAtIndex:section];
    return sectionHeaderView;
}

-(CGFloat)tableView:(UITableView *)tableView heightForHeaderInSection:(NSInteger)section
{
    return 25.0;
}

@end
