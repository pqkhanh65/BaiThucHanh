using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace BaiThucHanh.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [
            Display(Name="Họ Và Tên"),
            Required (ErrorMessage ="Họ tên không dể trống"),
          MinLength(6, ErrorMessage ="Họ tên ít nhất 6 ký tự"),
            MaxLength(20, ErrorMessage = "Họ tên tối đa 20 ký tự")
            
            ]
        public string FullName { get; set; }

        [Display (Name ="Địa chỉ email")]
        [Required(ErrorMessage ="Địa chỉ email không để trống")]
        [EmailAddress (ErrorMessage = "Địa chỉ email không đúng định dạng")]
        public string Email { get; set; }

        [Display(Name ="Số điện thoại")]
        [DataType (DataType.PhoneNumber)]
        [Remote (action: "VertfyPhone", controller: "Account")]
        [Required (ErrorMessage ="Số điện thoại không được để trống")]
        public string Phone { get; set; }

        [Display(Name ="Địa chỉ thường trú")]
        [Required(ErrorMessage="Địa chỉ không được bỏ trống")]
        [StringLength (35, ErrorMessage="Địa chỉ không vượt quá 35 ký tự")]
        public string Address { get; set; }
        [Display(Name = "Ảnh đại diện")]
        public string Avatar { get; set; }

        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [Display(Name = "Giới tính")]
        public string Gender { get; set; }

        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Link Facebook cá nhân")]
        [Required(ErrorMessage = "Link Facebook không được để trống")]
        [Url(ErrorMessage = "Url phải đúng định dạng bao gồm http hoặc https, tên miền VD: https://facebook.com")]
        public string Facebook { get; set; }

    }
}