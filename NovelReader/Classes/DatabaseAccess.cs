using NovelReaderWebScrapper.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace NovelReader.Classes
{
    public class DatabaseAccess
    {
        public static DataTable LoadFavoriteModel()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                {
                    sqlcon.Open();
                    string query = "Select * from NovelFavorites";
                    using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                    {
                        using (SQLiteDataReader dr = sqlcmd.ExecuteReader())
                        {
                            try
                            {
                                dt.Load(dr);
                            }
                            finally
                            {
                                if (sqlcon.State == ConnectionState.Open)
                                {
                                    dr.Close();
                                    sqlcon.Close();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private static bool CheckNovelFavorites(string novel)
        {
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                {
                    sqlcon.Open();
                    string query = "SELECT NovelName from NovelFavorites where NovelName=@NovelName";
                    using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                    {
                                                        sqlcmd.Parameters.AddWithValue("@NovelName", novel);
                        using (SQLiteDataReader dr = sqlcmd.ExecuteReader())
                        {
                            try
                            {
                                if (dr.HasRows)
                                {
                                    while (dr.Read())
                                    {
                                        if (sqlcon.State == ConnectionState.Open)
                                        {
                                            sqlcon.Close();
                                            return false;
                                        }
                                    }
                                }
                                else
                                {
                                    if (sqlcon.State == ConnectionState.Open)
                                    {
                                        sqlcon.Close();
                                        return true;
                                    }
                                }
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }

        public static bool SaveNovelFavorites(string novelname, string novellink, string imglink, int sourcesite)
        {
            if(CheckNovelFavorites(novelname))
            {
                try
                {
                    using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                    {
                        sqlcon.Open();
                        string query = "INSERT INTO NovelFavorites VALUES (@ID,@NovelName,@NovelLink,@Img,@Source)";
                        using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                        {
                            try
                            {
                                sqlcmd.Parameters.AddWithValue("@ID", null);
                                sqlcmd.Parameters.AddWithValue("@NovelName", novelname);
                                sqlcmd.Parameters.AddWithValue("@NovelLink", novellink);
                                sqlcmd.Parameters.AddWithValue("@Img", imglink);
                                sqlcmd.Parameters.AddWithValue("@Source", sourcesite);
                                sqlcmd.ExecuteNonQuery();

                                if (sqlcon.State == ConnectionState.Open)
                                {
                                    sqlcon.Close();
                                    return true;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
            return false;
        }











        
        public static (int sourcesite, string chapterlink) ContinueReading(string novel)
        {
            string chapterlink = string.Empty;
            int sourcesite = 0;
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                {
                    sqlcon.Open();
                    string query = "SELECT PreviousChapterLink, Source from NovelHistory where NovelName=@NovelName";
                    using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                    {
                        sqlcmd.Parameters.AddWithValue("@NovelName", novel);
                        using (SQLiteDataReader dr = sqlcmd.ExecuteReader())
                        {
                            try
                            {
                                if (dr.HasRows)
                                {
                                    while (dr.Read())
                                    {
                                        chapterlink = dr.GetString(0).ToString();
                                        sourcesite = dr.GetInt32(1);
                                    }
                                }
                            }
                            finally
                            {
                                if (sqlcon.State == ConnectionState.Open)
                                {
                                    sqlcon.Close();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return (sourcesite, chapterlink);
        }
        private static bool CheckNovelHistory(string novel)
        {
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                {
                    sqlcon.Open();
                    string query = "SELECT NovelName from NovelHistory where NovelName=@NovelName";
                    using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                    {
                        sqlcmd.Parameters.AddWithValue("@NovelName", novel);
                        using (SQLiteDataReader dr = sqlcmd.ExecuteReader())
                        {
                            try
                            {
                                if (dr.HasRows)
                                {
                                    while (dr.Read())
                                    {
                                        if (sqlcon.State == ConnectionState.Open)
                                        {
                                            sqlcon.Close();
                                            return true;
                                        };
                                    }
                                }
                                else
                                {
                                    if (sqlcon.State == ConnectionState.Open)
                                    {
                                        sqlcon.Close();
                                        return false;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }
        public static void UpdatePreviousChapter(string title, string chapterlink, int sourcesite)
        {
            if(CheckNovelHistory(title))
            {
                try
                {
                    using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                    {
                        sqlcon.Open();
                        string query = "UPDATE NovelHistory SET PreviousChapterLink=@PreviousChapterLink WHERE NovelName=@NovelName";
                        using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                        {
                            try
                            {
                                sqlcmd.Parameters.AddWithValue("@NovelName", title);
                                sqlcmd.Parameters.AddWithValue("@PreviousChapterLink", chapterlink);
                                sqlcmd.ExecuteNonQuery();
                            }
                            finally
                            {
                                if (sqlcon.State == ConnectionState.Open)
                                {
                                    sqlcon.Close();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SQLiteConnection sqlcon = new SQLiteConnection(LoadConnectionString(), true))
                    {
                        sqlcon.Open();
                        string query = "INSERT INTO NovelHistory VALUES (@NovelName,@PreviousChapterLink,@Source)";
                        using (SQLiteCommand sqlcmd = new SQLiteCommand(query, sqlcon))
                        {
                            try
                            {
                                sqlcmd.Parameters.AddWithValue("@NovelName", title);
                                sqlcmd.Parameters.AddWithValue("@PreviousChapterLink", chapterlink);
                                sqlcmd.Parameters.AddWithValue("@Source", sourcesite);
                                sqlcmd.ExecuteNonQuery();
                                
                            }
                            finally
                            {
                                if (sqlcon.State == ConnectionState.Open)
                                {
                                    sqlcon.Close();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private protected static string LoadConnectionString()
        {
            return string.Format("Data source={0};Version=3;New=False;Compress=True;FailIfMissing=False",
                (Directory.GetCurrentDirectory().ToString().Replace(@"\bin\Debug", "") + @"\NovelReaderDB.db").Replace(@"\", @"\\"));
        }
    }
}
