﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBoletim.Context
{
    public class BoletimContext
    {
        SqlConnection con = new SqlConnection();
        public BoletimContext()
        {
            con.ConnectionString = @"Data Source=DESKTOP-DC44E8T\SQLEXPRESS;Initial Catalog=boletim;Persist Security Info=True;User ID=sa;Password=sa132";
        }

        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();   
            }
        }

    }
}
