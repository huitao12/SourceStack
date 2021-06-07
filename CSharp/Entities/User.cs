using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace CSharp.Entities
{
    [Index("CreateTime", IsUnique = true)]
    public sealed class User : Entity //让USer无法被继承
    {
        //public int Id { get; set; }

        //[Key]设置主键
        [Required(ErrorMessage = "*用户名不能为空")]
        public string Name { get; set; }

        [NotMapped]//不映射到数据库
        public string Introduction { get; set; }

        [MinLength(4, ErrorMessage = "*密码的长度不能小于4，大于20")]//不能为空
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsMale { get; set; }

        [Required(ErrorMessage = "*邀请人不能为空")]
        public User InvitedBy { get; set; }

        [StringLength(4, MinimumLength = 4, ErrorMessage = "*邀请码只能是4位数字")]
        [Required(ErrorMessage = "*邀请码不能为空")]
        public string InviteCode { get; set; }

        [NotMapped]//不映射到数据库
        public int FailedTry { get; set; }//添加尝试登陆失败次数

        public DateTime? CreateTime { get; set; }

        [NotMapped]//不映射到数据库
        public int BCredit { get; set; }
         public int EmailId { get; set; }
        public Email Email { get; set; }











    }
}
