using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseezBasic.UI.Models
{
    [DisplayName("شرکتها")]
    [Table("Company", Schema = "Base")]
    public class Company
    {
        public int ID { get; set; }

        [Display(Name = "نام شرکت")]
        public string CompanyName { get; set; }

        [Display(Name = "نام مستعار")]
        public string AliasName { get; set; }

        [Display(Name = "نام لاتین")]
        public string LatinName { get; set; }

        [Display(Name = "نام لاتین مستعار")]
        public string AliasLatinName { get; set; }

        [Display(Name = "کد شرکت")]
        public string ComapnyCode { get; set; }

        [Display(Name = "کد ملی")]
        public string NationalCode { get; set; }

        [Display(Name = "کد اقتصادی")]
        public string EconomyCode { get; set; }

        [Display(Name = "نام استان")]
        public string ProvinceName { get; set; }

        [Display(Name = "نام شهر")]
        public string City { get; set; }

        [Display(Name = "آدرس شرکت")]
        public string AddressCompany { get; set; }

        [Display(Name = "کد پسنی")]
        public string PostalCode { get; set; }

        [Display(Name = "شماره تلفن")]
        public string Tel { get; set; }

        [Display(Name = "شماره تلفن دوم")]
        public string Tel2 { get; set; }

        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Display(Name = "فکس")]
        public string Fax { get; set; }

        [Display(Name = "مدیر عامل")]
        public string CEO { get; set; }

        [Display(Name = "شماره موبایل 1")]
        public string Mobile1 { get; set; }

        [Display(Name = "شماره موبایل 2")]
        public string Mobile2 { get; set; }

        [Display(Name = "جانشین")]
        public string Seconder { get; set; }

        [Display(Name = "شماره موبایل جانشین")]
        public string MobileSeconder { get; set; }

        [Display(Name = "شماره موبایل دوم جانشین")]
        public string MobileSeconder2 { get; set; }

        [Display(Name = "نام نماینده")]
        public string NameAgent { get; set; }

        [Display(Name = "کد ملی نماینده")]
        public string NationalCodeAgent { get; set; }

        [Display(Name = "شماره تلفن جانشین")]
        public string PhoneAgent { get; set; }

        [Display(Name = "شماره موبایل جانشین")]
        public string MobileAgent { get; set; }

        [Display(Name = "نام نماینده دوم")]
        public string NameAgent2 { get; set; }

        [Display(Name = "کد ملی نماینده دوم")]
        public string NationalCodeAgent2 { get; set; }

        [Display(Name = "شماره تلفن نماینده دوم")]
        public string PhoneAgent2 { get; set; }

        [Display(Name = "شماره موبایل نماینده دوم")]
        public string MobileAgent2 { get; set; }

        [Display(Name = "شماره حساب")]
        public string AccountNumber { get; set; }

        [Display(Name = "شماره شبا")]
        public string ShebaNumber { get; set; }
    }
}