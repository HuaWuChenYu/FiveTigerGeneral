using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class AdoDBHelper : DBHelper
    {
        public override int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        public override object ExecuteScalar()
        {
            throw new NotImplementedException();
        }

        public override List<T> GetList<T>()
        {
            return new List<T>();
        }
    }
}
