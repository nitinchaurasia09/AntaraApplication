using BusinessWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AntaraApplication.Models
{
    public class PageMaster
    {
        public void saveUser()
        {
            try
            {
                Ado.ExecuteNoneQueryText("");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
    }
}