using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProgramDAL
{
    /// <summary>
    /// 数据库辅助类
    /// </summary>
    public class DbHelper
    {
        // 连接字符串
        static string ConStr = System.Configuration.ConfigurationManager.ConnectionStrings["AgriculturalMonitor"].ToString();

        #region 普通SQL语句的增删改
        /// <summary>
        /// 普通SQL语句的增删改
        /// </summary>
        /// <param name="sql">普通SQL语句</param>
        /// <returns>返回受影响的行数</returns>
        public static int CUD(string sql)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(ConStr);

                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);

                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region 参数化SQL语句的增删改
        /// <summary>
        /// 参数化SQL语句的增删改
        /// </summary>
        /// <param name="sql">参数化的SQL语句</param>
        /// <param name="sqlParameters">存储对象的集合</param>
        /// <returns>受影响的行数</returns>
        public static int CUD(string sql, List<SqlParameter> sqlParameters)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(ConStr);

                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);

                // 将集合转化为数组后添加
                cmd.Parameters.AddRange(sqlParameters.ToArray());

                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region 执行查询操作，返回SQLDataReader对象
        /// <summary>
        /// 执行查询操作，返回SQLDataReader对象
        /// </summary>
        /// <param name="sql">传入的SQL语句</param>
        /// <returns>SQLDataReader的对象</returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(ConStr);

                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);

                //CommandBehavior.CloseConnection用于设置当SqlDataReader关闭时会自动关闭连接
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                return sdr;
            }
            catch
            {
                return null;
            }
            finally
            {
                con?.Close();
            }
        }
        #endregion

        #region 执行查询操作，返回SQLDataReader对象（参数化查询）
        /// <summary>
        /// 执行查询操作，返回SQLDataReader对象（参数化查询）
        /// </summary>
        /// <param name="sql">传入的参数化SQL语句</param>
        /// <param name="sqlParameters">传入参数对象的数组</param>
        /// <returns>SQLDataReader的对象</returns>
        public static SqlDataReader GetReader(string sql, List<SqlParameter> sqlParameters)
        {
            SqlConnection con = new SqlConnection(ConStr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);

                // 正确添加参数
                if (sqlParameters != null && sqlParameters.Count > 0)
                {
                    cmd.Parameters.AddRange(sqlParameters.ToArray());
                }

                // 移除finally中的con.Close()，因为CommandBehavior.CloseConnection会处理
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                // 发生异常时确保连接关闭
                con?.Close();
                throw; // 重新抛出异常让调用方处理
            }
        }
        #endregion

        #region 执行查询操作，返回DataTable对象
        /// <summary>
        /// 执行查询操作，返回DataTable对象
        /// </summary>
        /// <param name="sql">普通SQL语句</param>
        /// <returns>DataTable对象</returns>
        public static DataTable GetDataTable(string sql)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(ConStr);

                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter(sql, con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region 执行查询操作，返回DataTable对象（参数化查询）
        /// <summary>
        /// 执行查询操作，返回DataTable对象（参数化查询）
        /// </summary>
        /// <param name="sql">参数化SQL语句</param>
        /// <param name="sqlParameters">传入参数对象的集合</param>
        /// <returns>DataTable对象</returns>
        public static DataTable GetDataTable(string sql, List<SqlParameter> sqlParameters)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(ConStr);

                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddRange(sqlParameters.ToArray());

                sda.SelectCommand = cmd;

                DataTable dt = new DataTable();

                sda.Fill(dt);

                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// 重载方法，使方法同时支持数组和List
        /// </summary>
        /// <param name="sql">参数化SQL语句</param>
        /// <param name="parameters">传入参数对象的数组</param>
        /// <returns>DataTable对象</returns>
        public static DataTable GetDataTable(string sql, SqlParameter[] parameters)
        {
            return GetDataTable(sql, parameters?.ToList());
        }
        #endregion

        #region 执行查询语句，返回第一行的第一个单元格的数据
        /// <summary>
        /// 执行查询语句，返回第一行的第一个单元格的数据
        /// </summary>
        /// <param name="sql">普通SQL语句</param>
        /// <returns>第一行的第一个单元格的数据</returns>
        public static object GetScalar(string sql)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(ConStr);

                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);

                return cmd.ExecuteScalar();
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region 执行参数化查询语句，返回第一行的第一个单元格的数据
        /// <summary>
        /// 执行参数化查询语句，返回第一行的第一个单元格的数据
        /// </summary>
        /// <param name="sql">参数化SQL语句</param>
        /// <returns>第一行的第一个单元格的数据</returns>
        public static object GetScalar(string sql, List<SqlParameter> sqlParameters)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(ConStr);

                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddRange(sqlParameters.ToArray());

                return cmd.ExecuteScalar();
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }
}
