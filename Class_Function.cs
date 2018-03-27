using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Common;
using System.Data.SQLite;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Net;
namespace MaterialSkinExample
{

	class Class_Function
	{
		public static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Base_list.db");
	//	public static string temp_name_video = "";
		static public void SQL_Playlist(MetroComboBox Playlist)
		{
			SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
			connection.Open();
			SQLiteCommand SQL_Playlist = new SQLiteCommand("select * FROM Table_PlayList", connection);
			
			SQLiteDataReader Reader_SQL = SQL_Playlist.ExecuteReader();
			foreach (DbDataRecord record in Reader_SQL)
			{
				Playlist.Items.Add(record["Video"]);
			}
			connection.Close();
		}
		static public string SQL_Open_video(string temp_name_video)
		{
			string url = "";
			SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
			connection.Open();
			SQLiteCommand SQL_Open = new SQLiteCommand("select * FROM Table_PlayList where Video='"+temp_name_video+"'", connection);
			SQLiteDataReader Reader_SQL_Video = SQL_Open.ExecuteReader();
			foreach (DbDataRecord record in Reader_SQL_Video)
			{
				url = (record["File"].ToString());
			}
			connection.Close();
			return url;
		}
        static public void SQL_Update_link_download(string old_link, string new_link)
        {
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
            connection.Open();
            using (SQLiteCommand SQL_Playlist = new SQLiteCommand("update Table_PlayList set File = @new where URL=@old;", connection))
            {
                SQL_Playlist.Parameters.AddWithValue("@old", old_link);
                SQL_Playlist.Parameters.AddWithValue("@new", new_link);
                SQL_Playlist.ExecuteNonQuery();
            }
            MessageBox.Show("blet");
            connection.Close();
        }
        private static string getResponse(string uri)
        {
            StringBuilder sb = new StringBuilder();
            byte[] buf = new byte[8192];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            int count = 0;
            do
            {
                count = resStream.Read(buf, 0, buf.Length);
                if (count != 0)
                {
                    sb.Append(Encoding.Default.GetString(buf, 0, count));
                }
            }
            while (count > 0);
            return sb.ToString();
        }
        private void Parse_Poster_Film(string url)
        {
        }
      //  public static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Base_list.db");
        static public void add_playlist(string link_video, string video_name)
        {
            string url = getResponse(link_video);
            string result = url.Substring(url.IndexOf("<a href=\"http://kinogo.club/uploads/", 0));
            string[] trimmed = result.Split('"');
            //LinkPoster.Add(trimmed[1]);
            result = trimmed[1];
            // MessageBox.Show(result);

            try
            {
                SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
                connection.Open();
                using (SQLiteCommand SQL_Playlist = new SQLiteCommand("insert into Table_Playlist (URL, Video, Poster,File) values (@URL, @Name_Video, @Poster,@File)", connection))
                {
                    SQL_Playlist.Parameters.AddWithValue("@URL", link_video);
                    SQL_Playlist.Parameters.AddWithValue("@File", link_video);
                    SQL_Playlist.Parameters.AddWithValue("@Name_Video", video_name);
                    SQL_Playlist.Parameters.AddWithValue("@Poster", result);
                    SQL_Playlist.ExecuteNonQuery();
                }
                connection.Close();
                MessageBox.Show("Добавлено");
                //   Play_Box_List.Items.Clear();
                //     Class_Function.SQL_Playlist(Play_Box_List);
            }
            catch (System.Data.SQLite.SQLiteException)
            {
                MessageBox.Show("Данный фильм уже был добавлен");
            }

        }
        //Получаем url от file
        static public string file_to_url(string old_http)
        {
            string url = "";
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
            connection.Open();
            SQLiteCommand SQL_Open = new SQLiteCommand("select * FROM Table_PlayList where File='" + old_http+ "'", connection);
            SQLiteDataReader Reader_SQL_Video = SQL_Open.ExecuteReader();
            foreach (DbDataRecord record in Reader_SQL_Video)
            {
                url = (record["url"].ToString());
            }
            return url;
        }

    }


  
}
