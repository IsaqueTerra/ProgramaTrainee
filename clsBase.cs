using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ProgramaTrainee
{
    public sealed class clsBase
    {
        private clsBase() { }

        public static void Alert(string mensagem, Page pagina)
        {
            pagina.ClientScript.RegisterStartupScript(pagina.GetType(),
                System.Guid.NewGuid().ToString(),
                string.Format("<script language='JavaScript'>alert('{0}');</script>",
                mensagem));
        }

    }
}