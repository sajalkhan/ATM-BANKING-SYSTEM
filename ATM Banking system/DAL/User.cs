using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    sealed class User:MyBase,IdataBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public double Balance { get; set; }
        public byte[] Image { get; set; }
        public string Password { get; set; }

        public bool Insert()
        {
            Command = CommandBuilder(@"insert into All_User(name, phoneNumber, address, balance, image)
                                    values (@name, @phoneNumber, @address, @balance, @image)");

            Command.Parameters.AddWithValue("@name",Name);
            Command.Parameters.AddWithValue("@phoneNumber",PhoneNumber);
            Command.Parameters.AddWithValue("@address", Address);
            Command.Parameters.AddWithValue("@balance", Balance);
            Command.Parameters.AddWithValue("@image", Image);

            return ExecuteNQ(Command);
        }

        public DataSet Select()
        {
            return ExecuteDS(@"select u.id, u.name, u.phonenumber, u.address, u.balance, u.image, i.role
                               from All_User as u
                               left join info i on u.id=i.userid where i.role='user'");
        }

        public bool SelectImage()
        {
            if (!Connection()) return false;

            Command=CommandBuilder(@"select u.id, u.image, u.balance, u.name, u.phonenumber, u.address, i.password
                                     from All_User as u
                                     left join info i on u.id=i.userid where i.password=@password");

            Command.Parameters.AddWithValue("@password",Password);

            Reader = Command.ExecuteReader();
            while(Reader.Read())
            {
                Image = (byte[])Reader["image"];
                Balance = (double)Reader["balance"];
                Id = (Int32)Reader["id"];
                Name = Reader["name"].ToString();
                PhoneNumber = Reader["phonenumber"].ToString();
                Address = Reader["address"].ToString();
                Password = Reader["password"].ToString();

                Reader.Close();
                return true;
            }
            Reader.Close();
            return false;
        }

        public bool Select_Balance()
        {
            if (!Connection()) return false;
            Command = CommandBuilder("select balance from All_User where id=@id");
            Command.Parameters.AddWithValue("@id",Id);

            Reader = Command.ExecuteReader();
            while(Reader.Read())
            {
                Balance = (double)Reader["balance"];
                Reader.Close();
                return true;
            }
            Reader.Close();
            return false;
        }

        public bool GetMaxId()
        {
            if (!Connection()) return false;
            Command = CommandBuilder("select MAX(Id) as id from All_User");
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Id = Convert.ToInt32(Reader["id"]);
                Reader.Close();
                return true;
            }
            Reader.Close();
            return false;
        }

        public bool Delete()
        {
            Command = CommandBuilder("delete from All_User where id=@id");
            Command.Parameters.AddWithValue("@id",Id);
            return ExecuteNQ(Command);

        }
        public bool Update()
        {
            Command = CommandBuilder("update All_User set balance=@balance where id=@id");
            Command.Parameters.AddWithValue("@balance",Balance);
            Command.Parameters.AddWithValue("@id",Id);
            return ExecuteNQ(Command);
        }

        public bool Update_All()
        {
            Command = CommandBuilder(@"update All_User 
                                       set All_User.name=@name, All_User.phonenumber=@phonenumber, All_User.address=@address, All_User.image=@image where All_User.id=@id
                                       update info set info.password=@password where info.userid=@id");
            Command.Parameters.AddWithValue("@id",Id);
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@phonenumber", PhoneNumber);
            Command.Parameters.AddWithValue("@address", Address);
            Command.Parameters.AddWithValue("@image", Image);
            Command.Parameters.AddWithValue("@password", Password);
            return ExecuteNQ(Command);
        }

        public bool Update_Admin()
        {
            Command = CommandBuilder(@"update All_User 
                                       set All_User.name=@name, All_User.phonenumber=@phonenumber, All_User.address=@address, All_User.balance=@balance where All_User.id=@id");

            Command.Parameters.AddWithValue("@id", Id);
            Command.Parameters.AddWithValue("@name", Name);
            Command.Parameters.AddWithValue("@phonenumber", PhoneNumber);
            Command.Parameters.AddWithValue("@address", Address);
            Command.Parameters.AddWithValue("@balance", Balance);
            return ExecuteNQ(Command);
        }

        public bool Table()
        {
            Command = CommandBuilder(@"create table All_User(
                                        id int identity primary key,
                                        name varchar(200),
                                        phoneNumber varchar(200),
                                        address varchar(200),
                                        balance float not null,
                                        image image)");

            Command.Parameters.AddWithValue("@name",Name);
            Command.Parameters.AddWithValue("@phoneNumber",PhoneNumber);
            Command.Parameters.AddWithValue("@address", Address);
            Command.Parameters.AddWithValue("@balance", Balance);
            Command.Parameters.AddWithValue("@image", Image);

            return ExecuteNQ(Command);
        }
    }
}
