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
    public sealed class User : Entity
    {

        //[Key]设置主键
        public string Name { get; set; }

        [NotMapped]//不映射到数据库
        public string Introduction { get; set; }

        public string Password { get; set; }
        public bool IsMale { get; set; }

        public User InvitedBy { get; set; }
        public string InviteCode { get; set; }

        [NotMapped]//不映射到数据库
        public int FailedTry { get; set; }//添加尝试登陆失败次数

        public DateTime? CreateTime { get; set; }

        [NotMapped]//不映射到数据库
        public int BCredit { get; set; }
        public int EmailId { get; set; }
        public Email Email { get; set; }

        public int Wallet { get; set; }









    }
}
