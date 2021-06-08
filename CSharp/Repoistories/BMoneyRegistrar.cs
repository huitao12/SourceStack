using CSharp.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Repoistories
{
    class BMoneyRegistrar
    {

        SqlDbContext context = new SqlDbContext();
        public void Change(int BuyerId, int SellId, int number)
        {
            //EF core：UoW和事务
            //用事务实现帮帮币出售的过程
            //卖方帮帮币足够，扣减数额后成功提交。 
            //卖房帮帮币不够，事务回滚，买卖双方帮帮币不变。 

            using (IDbContextTransaction transaction = context.Database.BeginTransaction())
            {
                try
                {
                    User Buyer = context.Users.Find(SellId);
                    Buyer.Wallet = Buyer.Wallet + number;

                    User Sell = context.Users.Find(BuyerId);

                    if (Sell.Wallet < 0)
                    {
                        return;
                    }
                    Sell.Wallet = Sell.Wallet - number;
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
