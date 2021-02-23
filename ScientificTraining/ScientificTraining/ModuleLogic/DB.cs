using System;
using System.Linq;
using System.Collections.Generic;
//用户自定义
using SqlSugar;
using ModuleLogic.Entity;

namespace ModuleLogic
{
    class DB
    {
        private SqlSugarClient db;

        public DB()
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
                    //
                };
            }
            catch (Exception ex)
            {
                //
            }

        }

        /*..........................................数据库操作API....................................................*/

        public user ValidateLogon(int userId)
        {
            try
            {
                if (db != null)
                    return db.Queryable<user>().Where(it => it.user_id == userId).First();
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<user> GetUsers(int coach_id)
        {
            try
            {
                if (db != null)
                    return db.Queryable<user>().Where(it => it.coach_id == coach_id).ToList();
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<user> GetUsers(string venue)
        {
            try
            {
                if (db != null)
                    return db.Queryable<user>().Where(it => it.venue == venue && it.role == 1).ToList();
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<user> GetCoach(string venue)
        {
            try
            {
                if (db != null)
                    return db.Queryable<user>().Where(it => it.venue == venue && it.role == 2).ToList();
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<plan> GetTrainingDate(int month)
        {
            try
            {
                var year = DateTime.Now.Year.ToString();

                if (db != null)
                    return db.SqlQueryable<plan>("select * from plan where year(plan.startTime)=" + year + " and month(plan.startTime)=" + month.ToString()).Where(it => it.coachId == int.Parse(ReadConfigure.ReadParameter(@"\Login.txt"))).ToList();
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<plan> GetTrainingPlanWithOneDay(string day)
        {
            try
            {
                if (db != null)
                    return db.SqlQueryable<plan>("select* from plan where date_format(startTime, '%Y-%m-%d') = '" + day + @"'").Where(it => it.coachId == int.Parse(ReadConfigure.ReadParameter(@"\Login.txt"))).ToList();
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<tablepower> GetTablePowers(int type)
        {
            try
            {
                if (db != null)
                    return db.Queryable<tablepower>().Where(it => it.Type == type).ToList();
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<train_action> GetTtrain_actions(int type)
        {
            try
            {
                if (db != null)
                    return db.Queryable<train_action>().Where(it => it.Type == type).ToList();
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<apptype> Getapptypes()
        {
            try
            {
                if (db != null)
                    return db.Queryable<apptype>().ToList();
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<roles> Getroles()
        {
            try
            {
                if (db != null)
                    return db.Queryable<roles>().ToList();
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<video> Getvideos(int coachId)
        {
            try
            {
                if (db != null)
                    return db.Queryable<video>().Where(it => it.coachId == coachId).ToList();
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<basic_data> Getbasic_datas(string user_id)
        {
            try
            {
                if (db != null)
                    return db.Queryable<basic_data>().Where(it => it.user_id == user_id).OrderBy(it => it.time).ToList();
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<functional_data> Getfunctional_datas(string user_id)
        {
            try
            {
                if (db != null)
                    return db.Queryable<functional_data>().Where(it => it.user_id == user_id).ToList();
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void InsertUser(user user)
        {
            try
            {
                var result = db.Insertable(user).ExecuteCommand();
            }
            catch (Exception ex)
            {

            }
        }

        public List<Instrument> GetInstruments(int user_id)
        {
            try
            {
                var user = db.Queryable<user>().Where(it => it.user_id == user_id).ToList().First();
                var result = db.Queryable<Instrument>().Where(it => it.phone == user.telephonenumber).ToList();

                if (result.Count < 5)
                    return result;
                else
                    return result.GetRange(0, 5);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<inBody> GetinBodys(int user_id)
        {
            try
            {
                var user = db.Queryable<user>().Where(it => it.user_id == user_id).ToList().First();
                var result = db.Queryable<inBody>().Where(it => it.phone == user.telephonenumber).ToList();

                if (result.Count < 5)
                    return result;
                else
                    return result.GetRange(0, 5);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void DeleteUser(string readName)
        {
            try
            {
                db.Deleteable<user>().Where(it => it.real_name == readName).ExecuteCommand();
            }
            catch (Exception ex)
            {

            }
        }

        public List<video> Getmarvellous(int coachId)
        {
            try
            {
                var reuslt = db.Queryable<video, marvellous>((Table_video, Table_marvellous) => new JoinQueryInfos(JoinType.Right, Table_video.id == Table_marvellous.VideoId)).Where(Table_video => Table_video.coachId == coachId).ToList();

                return reuslt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public void Insert(plan plan)
        {
            try
            {
                var result = db.Insertable(plan).ExecuteCommand();
            }
            catch (Exception ex)
            {

            }
        }

        public user GetUser(string userName)
        {
            try
            {
                if (db != null)
                    return db.Queryable<user>().Where(it => it.user_name == userName || it.real_name == userName).First();
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int IsExist(DateTime dt, int coachId)
        {
            try
            {
                return db.Queryable<plan>().ToList().Where(it => it.startTime.Year == dt.Year &&
                                                                 it.startTime.Month == dt.Month &&
                                                                 it.startTime.Day == dt.Day &&
                                                                 it.coachId == coachId).Count();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public void DeleteTraining(DateTime dt, int coachId)
        {
            try
            {
                var result = db.Queryable<plan>().ToList().Where(it => it.startTime.Year == dt.Year &&
                                                                  it.startTime.Month == dt.Month &&
                                                                  it.startTime.Day == dt.Day &&
                                                                  it.coachId == coachId);
                foreach (var item in result)
                    db.Deleteable<plan>().Where(it => it.PlanId == item.PlanId).ExecuteCommand();
            }
            catch (Exception ex)
            {

            }
        }

        public void Insertfunctional_data(functional_data functional)
        {
            try
            {
                var result = db.Insertable(functional).ExecuteCommand();
            }
            catch (Exception ex)
            {

            }
        }
    }

}
