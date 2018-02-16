using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    sealed class Info:MyBase,IdataBase
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }

        public bool Insert()
        {
            Command = CommandBuilder(@"insert into info(role, password, userid)
                                    values (@role, @password, @userid)");

            Command.Parameters.AddWithValue("@role",Role);
            Command.Parameters.AddWithValue("@password",Password);
            Command.Parameters.AddWithValue("@userid",UserId);

            return ExecuteNQ(Command);
        }

        public bool SelectById()
        {
            if (!Connection()) return false;

            Command = CommandBuilder(@"select i.role,i.userid,u.name
                                        from info as i
                                        left join All_User u on i.userid = u.id
                                        where i.password = @password");

            Command.Parameters.AddWithValue("@password",Password);
            Reader = Command.ExecuteReader();

            while(Reader.Read())
            {
                Role = Reader["role"].ToString();
                Name = Reader["name"].ToString();
                return true;
            }
            Reader.Close();
            return false;
        }

        public DataSet Select()
        {
            return ExecuteDS("select distinct role from info");
        }
        public bool Delete()
        {
            Command = CommandBuilder("delete from info where userid=@userid");
            Command.Parameters.AddWithValue("@userid",Id);
            return ExecuteNQ(Command);
        }
        public bool Table()
        {
            Command = CommandBuilder(@"create table Info(
	                                    id int identity primary key,
	                                    role varchar(20) not null,
	                                    password int unique not null,
	                                    userid int,
	                                    foreign key(userid) references All_User(id))");

            Command.Parameters.AddWithValue("@role",Role);
            Command.Parameters.AddWithValue("@password",Password);
            Command.Parameters.AddWithValue("@userid", UserId);
            return ExecuteNQ(Command);
        }
    }
}
