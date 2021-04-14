using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class TokenManager
    {
        //声明一个令牌管理（TokenManager）类：
        //使用私有的Token枚举_tokens存储所具有的权限
        //暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限
        //User类中添加一个Tokens属性，类型为TokenManager
        private Token _tokens ;
      
        public void ADD(Token token)
        {
            _tokens = _tokens | token;

        }
        public void Remove(Token token)
        {
            if (Has(token))
            {
                _tokens = _tokens ^ token;
            }
            else
            {
                Console.WriteLine("a");
            }
        }
        public bool Has(Token token)
        {
           return token ==(_tokens & token );
           
        }
    }
}
