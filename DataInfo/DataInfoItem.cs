1using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoBrowser.DataInfo
{
    public class DataInfoItem
    {

    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    public class Customer_contracts
    {
        public int folder_ID
        {
            get;
            set;
        }

        public string Contract_number
        {
            get;
            set;
        }

        public DateTime? Date_input
        {
            get;
            set;
        }

        public DateTime? Contract_date
        {
            get;
            set;
        }

        public int Shop_ID
        {
            get;
            set;
        }

        public int Goods_value
        {
            get;
            set;
        }

        public int Downpayment
        {
            get;
            set;
        }

        public string Second_payment
        {
            get;
            set;
        }

        public string Offline_contract
        {
            get;
            set;
        }

        public string Contract
        {
            get;
            set;
        }

        public int status
        {
            get;
            set;
        }

        public string Input_by
        {
            get;
            set;
        }

        public DateTime? Final_check_successfull
        {
            get;
            set;
        }

        public int Commission_report
        {
            get;
            set;
        }

        public string Goods_type
        {
            get;
            set;
        }

        public string check_op
        {
            get;
            set;
        }

        public bool ct
        {
            get;
            set;
        }

        public string ct_n
        {
            get;
            set;
        }

        public DateTime? ct_d
        {
            get;
            set;
        }

        public bool pv
        {
            get;
            set;
        }

        public string pv_n
        {
            get;
            set;
        }

        public DateTime? pv_d
        {
            get;
            set;
        }

        public bool rv
        {
            get;
            set;
        }

        public string rv_n
        {
            get;
            set;
        }

        public DateTime? rv_d
        {
            get;
            set;
        }

        public bool frb
        {
            get;
            set;
        }

        public string frb_n
        {
            get;
            set;
        }

        public DateTime? frb_d
        {
            get;
            set;
        }

        public bool qa
        {
            get;
            set;
        }

        public string qa_n
        {
            get;
            set;
        }

        public DateTime? qa_d
        {
            get;
            set;
        }

        public bool mrc
        {
            get;
            set;
        }

        public string mrc_n
        {
            get;
            set;
        }

        public DateTime? mrc_d
        {
            get;
            set;
        }

        public bool cf
        {
            get;
            set;
        }

        public string cf_n
        {
            get;
            set;
        }

        public DateTime? cf_d
        {
            get;
            set;
        }

        public bool id
        {
            get;
            set;
        }

        public string id_n
        {
            get;
            set;
        }

        public DateTime? id_d
        {
            get;
            set;
        }

        public bool risd
        {
            get;
            set;
        }

        public string risd_n
        {
            get;
            set;
        }

        public DateTime? risd_d
        {
            get;
            set;
        }

        public bool sfn
        {
            get;
            set;
        }

        public string sfn_n
        {
            get;
            set;
        }

        public DateTime? sfn_d
        {
            get;
            set;
        }

        public bool ncr
        {
            get;
            set;
        }

        public string ncr_n
        {
            get;
            set;
        }

        public DateTime? ncr_d
        {
            get;
            set;
        }

        public bool ncstc
        {
            get;
            set;
        }

        public string ncstc_n
        {
            get;
            set;
        }

        public DateTime? ncstc_d
        {
            get;
            set;
        }

        public bool bmrc
        {
            get;
            set;
        }

        public string bmrc_n
        {
            get;
            set;
        }

        public DateTime? bmrc_d
        {
            get;
            set;
        }

        public int psa
        {
            get;
            set;
        }

        public string psa_n
        {
            get;
            set;
        }

        public DateTime? psa_d
        {
            get;
            set;
        }

        public DateTime? Finish_p1
        {
            get;
            set;
        }

        public int D_stat
        {
            get;
            set;
        }

        public string finish_p1_n
        {
            get;
            set;
        }

        public bool tc
        {
            get;
            set;
        }

        public string tc_n
        {
            get;
            set;
        }

        public DateTime? tc_d
        {
            get;
            set;
        }

        public bool tl
        {
            get;
            set;
        }

        public string tl_n
        {
            get;
            set;
        }

        public DateTime? tl_d
        {
            get;
            set;
        }

        public bool m_ret
        {
            get;
            set;
        }

        public DateTime? m_ret_d
        {
            get;
            set;
        }

        public string m_ret_n
        {
            get;
            set;
        }

        public string archive_op
        {
            get;
            set;
        }

        public DateTime? Archiving_date
        {
            get;
            set;
        }

        public string Archive_box_number
        {
            get;
            set;
        }

        public DateTime? sent_to_ccr
        {
            get;
            set;
        }

        public string pv_no
        {
            get;
            set;
        }

        public DateTime? pv_date
        {
            get;
            set;
        }

        public int NARST
        {
            get;
            set;
        }

        public string op_rec
        {
            get;
            set;
        }

        public string op_sen
        {
            get;
            set;
        }

        public string op_ret
        {
            get;
            set;
        }

        public string op_mis
        {
            get;
            set;
        }

        public DateTime? dat_rec
        {
            get;
            set;
        }

        public DateTime? dat_sen
        {
            get;
            set;
        }

        public DateTime? dat_ret
        {
            get;
            set;
        }

        public DateTime? dat_mis
        {
            get;
            set;
        }

        public bool canceled
        {
            get;
            set;
        }

        public string canceled_op
        {
            get;
            set;
        }

        public DateTime? canceled_d
        {
            get;
            set;
        }

        public int RI_value
        {
            get;
            set;
        }

        public string RI_tax
        {
            get;
            set;
        }

        public bool lc
        {
            get;
            set;
        }

        public string lc_n
        {
            get;
            set;
        }

        public DateTime? lc_d
        {
            get;
            set;
        }

        public bool ps
        {
            get;
            set;
        }

        public string ps_n
        {
            get;
            set;
        }

        public DateTime? ps_d
        {
            get;
            set;
        }

        public bool mb
        {
            get;
            set;
        }

        public string mb_n
        {
            get;
            set;
        }

        public DateTime? mb_d
        {
            get;
            set;
        }

        public bool ofl
        {
            get;
            set;
        }

        public string ofl_n
        {
            get;
            set;
        }

        public DateTime? ofl_d
        {
            get;
            set;
        }

        public string Product_type
        {
            get;
            set;
        }

        public string SA
        {
            get;
            set;
        }

        public string City
        {
            get;
            set;
        }

        public string Client
        {
            get;
            set;
        }

        public bool in_cont
        {
            get;
            set;
        }

        public DateTime? in_cont_d
        {
            get;
            set;
        }

        public string in_cont_n
        {
            get;
            set;
        }

        public bool tel
        {
            get;
            set;
        }

        public string tel_n
        {
            get;
            set;
        }

        public DateTime? tel_d
        {
            get;
            set;
        }

        public bool dl
        {
            get;
            set;
        }

        public string dl_n
        {
            get;
            set;
        }

        public DateTime? dl_d
        {
            get;
            set;
        }

        public DateTime? Homer_signed
        {
            get;
            set;
        }

        public string narst_box
        {
            get;
            set;
        }

        public string narst_op
        {
            get;
            set;
        }

        public DateTime? narst_date
        {
            get;
            set;
        }

        public string aet_box
        {
            get;
            set;
        }

        public string aet_op
        {
            get;
            set;
        }

        public DateTime? aet_date
        {
            get;
            set;
        }

        public bool aet
        {
            get;
            set;
        }

        public string init_link
        {
            get;
            set;
        }

        public string narst_link
        {
            get;
            set;
        }

        public string aet_link
        {
            get;
            set;
        }

        public string stat_pres
        {
            get;
            set;
        }

        public string homer_status
        {
            get;
            set;
        }

        public DateTime? homer_status_d
        {
            get;
            set;
        }

        public DateTime? add_verified_d
        {
            get;
            set;
        }

        public string add_verified_n
        {
            get;
            set;
        }

        public string add1
        {
            get;
            set;
        }

        public string add2
        {
            get;
            set;
        }

        public string add3
        {
            get;
            set;
        }

        public string add4
        {
            get;
            set;
        }

        public string add5
        {
            get;
            set;
        }

        public string mrc_fin_n
        {
            get;
            set;
        }

        public DateTime? mrc_fin_d
        {
            get;
            set;
        }

        public string Insurance_value
        {
            get;
            set;
        }

        public DateTime? Sent_for_check
        {
            get;
            set;
        }

        public DateTime? Finances_accepted
        {
            get;
            set;
        }

        public int Pay_to
        {
            get;
            set;
        }

        public int Group_payment_ref
        {
            get;
            set;
        }

        public int Red_invoice_2nd_payment
        {
            get;
            set;
        }

        public int Dealer
        {
            get;
            set;
        }

        public bool Match
        {
            get;
            set;
        }

        public string PAYMENT_TYPE
        {
            get;
            set;
        }

        public bool Select_to_clear
        {
            get;
            set;
        }

        public DateTime? AP_CLEARED
        {
            get;
            set;
        }

        public string Payment_file
        {
            get;
            set;
        }

        public DateTime? Bank_date
        {
            get;
            set;
        }

        public bool Send_to_archive
        {
            get;
            set;
        }

        public bool Boxing
        {
            get;
            set;
        }

        public int Related
        {
            get;
            set;
        }

        public DateTime? Date_approved
        {
            get;
            set;
        }

        public bool offline
        {
            get;
            set;
        }

        public int Offline_contract_management
        {
            get;
            set;
        }

        public float Per_cent
        {
            get;
            set;
        }

        public string mark_op
        {
            get;
            set;
        }

        public int INV_STAT
        {
            get;
            set;
        }

        public DateTime? Ri_prep
        {
            get;
            set;
        }

        public string paytoacc
        {
            get;
            set;
        }

        public string paytobank
        {
            get;
            set;
        }

        public string cleared_by
        {
            get;
            set;
        }

        public DateTime? Cleared_on
        {
            get;
            set;
        }

        public string aet_n
        {
            get;
            set;
        }

        public DateTime? aet_d
        {
            get;
            set;
        }

        public bool ins_ct
        {
            get;
            set;
        }

        public string ins_n
        {
            get;
            set;
        }

        public DateTime? ins_d
        {
            get;
            set;
        }

        public string salesman
        {
            get;
            set;
        }

        public int mc_period
        {
            get;
            set;
        }

        public string other
        {
            get;
            set;
        }

        public DateTime? oth_d
        {
            get;
            set;
        }

        public string oth_n
        {
            get;
            set;
        }

        public string Shop_type
        {
            get;
            set;
        }

        public bool af
        {
            get;
            set;
        }

        public string af_n
        {
            get;
            set;
        }

        public DateTime? af_d
        {
            get;
            set;
        }

        public bool vf
        {
            get;
            set;
        }

        public string vf_n
        {
            get;
            set;
        }

        public DateTime? vf_d
        {
            get;
            set;
        }

        public DateTime? activated
        {
            get;
            set;
        }

        public bool wvf
        {
            get;
            set;
        }

        public string wvf_n
        {
            get;
            set;
        }

        public DateTime? wvf_d
        {
            get;
            set;
        }

        public bool mtk
        {
            get;
            set;
        }

        public string mtk_n
        {
            get;
            set;
        }

        public DateTime? mtk_d
        {
            get;
            set;
        }

        public bool plm
        {
            get;
            set;
        }

        public string plm_n
        {
            get;
            set;
        }

        public DateTime? plm_d
        {
            get;
            set;
        }

        public bool loc
        {
            get;
            set;
        }

        public string loc_n
        {
            get;
            set;
        }

        public DateTime? loc_d
        {
            get;
            set;
        }

        public bool rod
        {
            get;
            set;
        }

        public string rod_n
        {
            get;
            set;
        }

        public DateTime? rod_d
        {
            get;
            set;
        }

        public string env_ve_no
        {
            get;
            set;
        }

        public string client_picture_note
        {
            get;
            set;
        }

        public bool alt_missing
        {
            get;
            set;
        }

        public string alt_missing_n
        {
            get;
            set;
        }

        public DateTime? alt_missing_d
        {
            get;
            set;
        }

        public bool alt_received
        {
            get;
            set;
        }

        public string alt_received_n
        {
            get;
            set;
        }

        public DateTime? alt_received_d
        {
            get;
            set;
        }

        public bool alt_sent
        {
            get;
            set;
        }

        public string alt_sent_n
        {
            get;
            set;
        }

        public DateTime? alt_sent_d
        {
            get;
            set;
        }

        public bool alt_returned
        {
            get;
            set;
        }

        public string alt_returned_n
        {
            get;
            set;
        }

        public DateTime? alt_returned_d
        {
            get;
            set;
        }

        public bool alt_canceled
        {
            get;
            set;
        }

        public string alt_canceled_n
        {
            get;
            set;
        }

        public DateTime? alt_canceled_d
        {
            get;
            set;
        }

        public string alt_status
        {
            get;
            set;
        }

        public string ddt_bank_name
        {
            get;
            set;
        }

        public string ddt_status
        {
            get;
            set;
        }

        public string client_bank_account_id
        {
            get;
            set;
        }

        public string client_bank_account_name
        {
            get;
            set;
        }

        public string client_home_phone
        {
            get;
            set;
        }

        public string client_cell_phone
        {
            get;
            set;
        }

        public string client_picture_note_n
        {
            get;
            set;
        }

        public DateTime? client_picture_note_d
        {
            get;
            set;
        }

        public bool business_registration_certificate
        {
            get;
            set;
        }

        public string business_registration_certificate_n
        {
            get;
            set;
        }

        public DateTime? business_registration_certificate_d
        {
            get;
            set;
        }

        public bool tax_certificate
        {
            get;
            set;
        }

        public string tax_certificate_n
        {
            get;
            set;
        }

        public DateTime? tax_certificate_d
        {
            get;
            set;
        }

        public bool operating_licence
        {
            get;
            set;
        }

        public string operating_licence_n
        {
            get;
            set;
        }

        public DateTime? operating_licence_d
        {
            get;
            set;
        }

        public string cp_family_status
        {
            get;
            set;
        }

        public string cp_family_status_n
        {
            get;
            set;
        }

        public DateTime? cp_family_status_d
        {
            get;
            set;
        }

        public string send_mrc_status
        {
            get;
            set;
        }

        public string verify_address_status
        {
            get;
            set;
        }

        public bool dnt
        {
            get;
            set;
        }

        public string dnt_n
        {
            get;
            set;
        }

        public DateTime? dnt_d
        {
            get;
            set;
        }

        public string id_credit
        {
            get;
            set;
        }

        public string client_id_card_no
        {
            get;
            set;
        }

        public string direct_debit_box_number
        {
            get;
            set;
        }

        public string direct_debit_op
        {
            get;
            set;
        }

        public DateTime? direct_debit_date
        {
            get;
            set;
        }

        public bool mrc_mandatory
        {
            get;
            set;
        }

        public bool check_document_metrix
        {
            get;
            set;
        }

        public bool alt_mistake
        {
            get;
            set;
        }

        public string alt_mistake_n
        {
            get;
            set;
        }

        public DateTime? alt_mistake_d
        {
            get;
            set;
        }

        public bool alt_ddc
        {
            get;
            set;
        }

        public string alt_ddc_n
        {
            get;
            set;
        }

        public DateTime? alt_ddc_d
        {
            get;
            set;
        }

        public bool receipt
        {
            get;
            set;
        }

        public string receipt_n
        {
            get;
            set;
        }

        public DateTime? receipt_d
        {
            get;
            set;
        }

        public string canceled_new
        {
            get;
            set;
        }

        public DateTime? approved_date
        {
            get;
            set;
        }

        public string client_pic_file
        {
            get;
            set;
        }

        public string mrc_plate_number
        {
            get;
            set;
        }

        public string mrc_plate_operator
        {
            get;
            set;
        }

        public DateTime? mrc_plate_operator_day
        {
            get;
            set;
        }

        public int sources
        {
            get;
            set;
        }

        public string payment_done
        {
            get;
            set;
        }

        public bool mrc_plate
        {
            get;
            set;
        }

        public int registration_status
        {
            get;
            set;
        }

        public int ct_packages_location
        {
            get;
            set;
        }

        public bool contract_package_archived
        {
            get;
            set;
        }

        public bool drd_alt_new
        {
            get;
            set;
        }

        public string drd_alt_new_n
        {
            get;
            set;
        }

        public DateTime? drd_alt_new_d
        {
            get;
            set;
        }

        public bool drd_alt_available
        {
            get;
            set;
        }

        public string drd_alt_available_n
        {
            get;
            set;
        }

        public DateTime? drd_alt_available_d
        {
            get;
            set;
        }

        public bool drd_alt_confir
        {
            get;
            set;
        }

        public string drd_alt_confir_n
        {
            get;
            set;
        }

        public DateTime? drd_alt_confir_d
        {
            get;
            set;
        }

        public bool drd_alt_receive_app
        {
            get;
            set;
        }

        public string drd_alt_receive_app_n
        {
            get;
            set;
        }

        public DateTime? drd_alt_receive_app_d
        {
            get;
            set;
        }

        public bool drd_alt_receive_rej
        {
            get;
            set;
        }

        public string drd_alt_receive_rej_n
        {
            get;
            set;
        }

        public DateTime? drd_alt_receive_rej_d
        {
            get;
            set;
        }

        public bool drd_alt_finish
        {
            get;
            set;
        }

        public string drd_alt_finish_n
        {
            get;
            set;
        }

        public DateTime? drd_alt_finish_d
        {
            get;
            set;
        }

        public bool drd_alt_cancel
        {
            get;
            set;
        }

        public string drd_alt_cancel_n
        {
            get;
            set;
        }

        public DateTime? drd_alt_cancel_d
        {
            get;
            set;
        }

        public string drd_status
        {
            get;
            set;
        }


    }

}
