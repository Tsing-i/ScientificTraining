using System;
//用户自定义
using ScientificTraining.tempEntity;
//数据库框架
using SqlSugar;

namespace ScientificTraining
{
    public class sqlSugarhelper
    {
        private SqlSugarClient db;

        //构造函数
        public sqlSugarhelper()
        {
            try
            {
                db = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = "Server=39.106.24.239;Uid=qdzt_pc;Pwd=qwer1234;Database=qinggermanassistant;allow zero datetime = true; convert zero datetime=True",
                    DbType = DbType.MySql,
                    IsAutoCloseConnection = true,
                    InitKeyType = InitKeyType.Attribute
                });

                db.Aop.OnLogExecuting = (sql, pars) =>
                {
                    
                };
            }
            catch (Exception ex)
            {
               
            }
        }

        /*..........................................数据库操作API....................................................*/

        public user ValidateLogon(string usrName)
        {
            try
            {
                if (db != null)
                    return db.Queryable<user>().Where(it => it.user_name == usrName).First();
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}
