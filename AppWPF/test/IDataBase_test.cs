using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Indusoft.Common.ConfigSQL
{
    interface IDataBase_test
    {
        DbConnection DbConnection { get; set; }
        DbCommand DbCommand { get; set; }
    }
}
