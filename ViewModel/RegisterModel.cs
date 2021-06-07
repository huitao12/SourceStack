using System.ComponentModel.DataAnnotations;


namespace CSharp.SRV.ViewModel
{
    public  class RegisterModel 
    {
        [Required(ErrorMessage = "*用户名不能为空")]
        public string Name { get; set; }

        [MinLength(4, ErrorMessage = "*密码的长度不能小于4，大于20")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "*邀请人不能为空")]
        public string InvitedByUserName { get; set; }

        [StringLength(4, MinimumLength = 4, ErrorMessage = "*邀请码只能是4位数字")]
        [Required(ErrorMessage = "*邀请码不能为空")]
        public string InviteByCode { get; set; }

    }
}
