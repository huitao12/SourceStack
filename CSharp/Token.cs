using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public enum Token
    {
        //作业：
        //声明一个令牌（Token）枚举，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered。
        //声明一个令牌管理（TokenManager）类：
        //使用私有的Token枚举_tokens存储所具有的权限
        //暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限
        //User类中添加一个Tokens属性，类型为TokenManager
        SuperAdmin = 1,
        Admin = 2,
        Blogger = 4,
        Newbie = 8,
        Registered = 16
    }
    public class TokenManager
    {
        private Token _tokens;

        public void ADD(Token token)
        {
            _tokens = _tokens | token;

        }
        public void Remove(Token token)
        {
            _tokens = _tokens ^ token;

        }
        public void Has(Token token)
        {
           _tokens = _tokens & token;
        }


    }
}
