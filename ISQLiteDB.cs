using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Bitki
{
    public  interface ISQLiteDB
    {
        SQLiteAsyncConnection GetConnection();
    }
}
