using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using AdvertisingAgency.Models.CompositeModel;

namespace AdvertisingAgency.Models
{
    public static class DaoMode
    {
        public static bool StaffLogin(StaffModel staff, string postgres)
        {
            string request = $"Select Stafflogin('{staff.tel}', '{staff.password}');";
            List<string[]> info = Request(request, postgres);

            foreach(string[] reader in info)
            {
                staff.id = int.Parse(reader[0]);
                return true;
            }
            
            return false;
        }

        public static bool GetStaffById(StaffModel staff, string postgres)
        {
            string request = $"Select * From Staff where id = '{staff.id}'";
            List<string[]> info = Request(request, postgres);

            foreach (string[] render in info)
            {
                staff.id = int.Parse(render[0]);
                staff.first_name = render[1];
                staff.last_name = render[2];
                staff.date_of_birthday = DateTime.Parse(render[3]);
                staff.sex = render[4];
                staff.tel = render[5];
                staff.password = render[6];
                return true;
            }

            return false;
        }

        public static bool ClientLogin(ClientCompanyModel client, string postgres)
        {
            string request = $"Select ClientLogin_tel('{client.tel}', '{client.password}');";
            List<string[]> info = Request(request, postgres);

            foreach (string[] render in info)
            {
                client.id = int.Parse(render[0]);
                return true;
            }

            request = $"Select ClientLogin_email('{client.tel}', '{client.password}');";
            info = Request(request, postgres);

            foreach (string[] render in info)
            {
                client.id = int.Parse(render[0]);
                return true;
            }

            return false;
        }

        public static bool CheckClientByCompanyName(ClientCompanyModel client, string postgres)
        {
            string request = $"Select * From Client_Company where company_name = '{client.company_name}'";
            List<string[]> info = Request(request, postgres);

            foreach(string[] reader in info)
            {
                client.id = int.Parse(reader[0]);
                client.company_name = reader[1];
                client.director = reader[2];
                client.city = reader[3];
                client.street = reader[4];
                client.first_name = reader[5];
                client.last_name = reader[6];
                client.tel = reader[7];
                client.email = reader[8];
                client.password = reader[9];
                return true;
            }

            return false;
        }

        public static bool CheckClientByTel(ClientCompanyModel client, string postgres)
        {
            string request = $"Select * From Client_Company where tel = '{client.tel}'";
            List<string[]> info = Request(request, postgres);

            foreach (string[] reader in info)
            {
                client.id = int.Parse(reader[0]);
                client.company_name = reader[1];
                client.director = reader[2];
                client.city = reader[3];
                client.street = reader[4];
                client.first_name = reader[5];
                client.last_name = reader[6];
                client.tel = reader[7];
                client.email = reader[8];
                client.password = reader[9];
                return true;
            }

            return false;
        }

        public static bool CheckClientByEmail(ClientCompanyModel client, string postgres)
        {
            string request = $"Select * From Client_Company where email = '{client.email}'";
            List<string[]> info = Request(request, postgres);

            foreach (string[] reader in info)
            {
                client.id = int.Parse(reader[0]);
                client.company_name = reader[1];
                client.director = reader[2];
                client.city = reader[3];
                client.street = reader[4];
                client.first_name = reader[5];
                client.last_name = reader[6];
                client.tel = reader[7];
                client.email = reader[8];
                client.password = reader[9];
                return true;
            }

            return false;
        }

        public static bool AddClient(ClientCompanyModel client, string postgres)
        {
            if (client.company_name == "" || client.first_name == "" || client.last_name == "" || client.city == "" || client.street == "" || client.tel == "" || client.email == "" || client.password == "")
                return false;

            string request = $"Insert Into Client_Company (company_name, director, city, street, first_name, last_name, tel, email, password) Values('{client.company_name}','{client.director}','{client.city}','{client.street}','{client.first_name}','{client.last_name}','{client.tel}','{client.email}','{client.password}') Returning id;";
            List<string[]> info = Request(request, postgres);
            foreach(string[] reader in info)
            {
                client.id = int.Parse(reader[0]);
            }

            return true;
        }

        public static bool GetStaffPositionByStaffId(StaffPositionModel staffPosition, string postgres)
        {
            string request = $"Select * From Staff_Position where staff_id = '{staffPosition.staff_id}';";
            List<string[]> info = Request(request, postgres);

            foreach (string[] render in info)
            {
                staffPosition.id = int.Parse(render[0]);
                staffPosition.position_id = int.Parse(render[2]);
                staffPosition.start_work = DateTime.Parse(render[3]);
                if(render[4] != "")
                    staffPosition.end_work = DateTime.Parse(render[4]);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Списки
        /// </summary>
        
        public static List<PositionModel> GetAllPosition(string postgres)
        {
            List<PositionModel> positions = new List<PositionModel>();

            string request = "Select * From Position";
            List<string[]> info = Request(request, postgres);

            foreach (string[] reader in info)
            {
                PositionModel position = new PositionModel();

                position.id = int.Parse(reader[0]);
                position.name = reader[1];
                position.salary = float.Parse(reader[2]);

                positions.Add(position);
            }

            return positions;
        }

        public static List<StaffModel> GetAllStaff(string postgres)
        {
            List<StaffModel> staffs = new List<StaffModel>();

            string request = "Select * From Staff";
            List<string[]> info = Request(request, postgres);

            foreach (string[] render in info)
            {
                StaffModel staff = new StaffModel();

                staff.id = int.Parse(render[0]);
                staff.first_name = render[1];
                staff.last_name = render[2];
                staff.date_of_birthday = DateTime.Parse(render[3]);
                staff.sex = render[4];
                staff.tel = render[5];
                staff.password = render[6];

                staffs.Add(staff);
            }

            return staffs;
        }

        public static List<StaffPositionModel> GetAllStaffPosition(string postgres)
        {
            List<StaffPositionModel> staffPositions = new List<StaffPositionModel>();

            string request = "Select * From Staff";
            List<string[]> info = Request(request, postgres);

            foreach (string[] render in info)
            {
                StaffPositionModel staffPosition = new StaffPositionModel();

                staffPosition.id = int.Parse(render[0]);
                staffPosition.position_id = int.Parse(render[2]);
                staffPosition.start_work = DateTime.Parse(render[3]);
                if (render[4] != "")
                    staffPosition.end_work = DateTime.Parse(render[4]);

                staffPositions.Add(staffPosition);
            }

            return staffPositions;
        }

        public static List<Staff_StaffPosition_Position> GetFullStaffInfo(string postgres)
        {
            List<Staff_StaffPosition_Position> fullStaffs = new List<Staff_StaffPosition_Position>();

            string request = "Select * From GetAllStaff();";
            List<string[]> info = Request(request, postgres);

            foreach (string[] render in info)
            {
                Staff_StaffPosition_Position s_sp_p = new Staff_StaffPosition_Position();
                StaffModel staff = new StaffModel();
                StaffPositionModel staffPosition = new StaffPositionModel();
                PositionModel position = new PositionModel();

                staff.id = int.Parse(render[0]);
                staff.first_name = render[1];
                staff.last_name = render[2];
                staff.date_of_birthday = DateTime.Parse(render[3]);
                staff.sex = render[4];
                staff.tel = render[5];
                staff.password = render[6];
                s_sp_p.staff = staff;

                staffPosition.id = int.Parse(render[7]);
                staffPosition.staff_id = staff.id;
                staffPosition.position_id = int.Parse(render[8]);
                staffPosition.start_work = DateTime.Parse(render[9]);
                if (render[10] != "")
                    staffPosition.end_work = DateTime.Parse(render[10]);
                s_sp_p.staffPosition = staffPosition;

                position.id = staffPosition.position_id;
                position.name = render[11];
                position.salary = float.Parse(render[12]);
                s_sp_p.position = position;

                fullStaffs.Add(s_sp_p);
            }

            return fullStaffs;
        }

        private static List<string[]> Request(string request,string postgres)
        {
            List<string[]> info = new List<string[]>();
            DBConect db = new DBConect(postgres);
            db.OpenConnection();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand(request, db.getConnection());
            npgsqlDataAdapter.SelectCommand = command;
            NpgsqlDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                if (Reader[0].ToString() == "")
                    break;

                string[] value = new string[Reader.FieldCount];
                for(int i = 0; i < value.Length; i++)
                {
                    value[i] = Reader[i].ToString();
                }

                info.Add(value);
            }
            db.CloseConnection();

            return info;
        }
    }
}
