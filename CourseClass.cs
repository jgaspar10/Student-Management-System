using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
    class CourseClass
    {
        DBconnect connect = new DBconnect();
        // create a function to insert course
        public bool InsertCourse(string Cname, int dur, string desc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `courses`(`Course Name`, `Course Duration`, `Description`) VALUES (@cn, @cd, @desc)", connect.getconnection);
            // @cn, @cd, @desc
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = Cname;
            command.Parameters.Add("@cd", MySqlDbType.Int32).Value = dur;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            connect.openConnect();
            if(command.ExecuteNonQuery()== 1)
            {
                connect.openConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        // Create funtion to get course list
        public DataTable GetCourse(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // create update function for course
        public bool UpdateCourse(int id, string Cname, int dur, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `courses` SET `Course Name`=@cn,`Course Duration`=@dur,`Description`= @desc WHERE `Course ID`=@id", connect.getconnection);
            // @id, @cn, @cd, @desc
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = Cname;
            command.Parameters.Add("@dur", MySqlDbType.Int32).Value = dur;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;


            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        // create a function to delete course data
        public bool deleteCourse(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `courses` WHERE`Course ID`= @id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
    }

}
