using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;


namespace Helpers
{
    /// <summary>
    /// All = 2, Active = 1, Inactive = -1, Pending = 0
    /// </summary>
    public enum Status
    {
        All = 2,
        Active = 1,
        Inactive = -1,
        Pending = 0
    }

    public enum MainActions
    {
        VIEW_ALL = 1,
        VIEW_DETAILS = 2,
        EDIT = 3,
        DELETE = 4,
        INSERT = 5
    }

    public enum MessageTypes
    {
        Error = -1,
        Inform = 0,
        Success = 1

    }

    public enum SessionKeyList
    {
        admin_notify_message = 1,
        front_end_notify_message = 2,
        page_title = 3,
        current_language = 4,
        rows_per_page = 5,
        rows_count_binding = 6,
        rows_count_total = 15,
        message_success = 7,
        message_error = 8,
        message_inform = 9,
        current_url = 10,
        gateway_action = 11,
        user_authorized = 12,
        user_not_authorized_message = 14,
        SupplierID = 16,
        total_debt = 17,
        fund_out = 18,
        logged_user_id = 19,
        logged_user_name = 20,
        logged_user_first_name = 21,
        logged_user_last_name = 22,
        logged_user_employee_id = 23,
        must_change_pass = 24,
        logged_user_type = 25,
        reset_pass = 26,
    }

    public enum LogStatus
    {
        SUCCESS = 1,
        FAILED = -1,
        NORMAL = 0
    }

    public enum GroupName
    {
        SUPPLIER,
        PRODUCT,
        CUSTOMER,
        ORDER
    }

    public enum CustomerCategory
    {
        CONTACT_INFO,
        ORDER_INFO,
        DELIVERY_INFO,
        TRANSPORTER_INFO,
        LABEL_INFO
    }

    public enum SaleType
    {
        WHOLESALE = 1,
        RETAIL = 2
    }

    public enum LogGroup
    { 
        SEC_ROLE = 1,
        SEC_ROLE_USER = 2,
        SEC_ROLE_PAGE = 3,
        SEC_USER = 4,
        SEC_USER_ROLE = 5,
        SEC_PAGE = 6,
        SEC_PAGE_ROLE = 7,
        SEC_SETTING = 8,
        SEC_SETTING_GROUP = 9,
        BRANCH = 10,
        CATEGORY = 11,
        CUSTOMER = 12,
        EMPLOYEE = 13,
        FUND_INCOME = 14,
        FUND_OUT = 15,
        HOME = 16,
        ORDER = 17,
        PRODUCT = 18,
        REPORT_DEPT = 19,
        RETURN_PRODUCT = 20,
        SUPPLIER_PRODUCT = 21,
        USER = 22,
        ERROR = 23,
        SYSTEM = 24
    }
}
