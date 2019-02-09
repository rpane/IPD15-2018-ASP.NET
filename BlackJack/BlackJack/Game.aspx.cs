using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlackJack
{
    public partial class Game : System.Web.UI.Page
    {
        string[,] deck = new string[4, 13] { { "1c", "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "10c", "jc", "kc", "qc" },
            { "1d", "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "10d", "jd", "kd", "qd" }, { "1h", "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "10h", "jh", "kh", "qh" },
        { "1s", "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "10s", "js", "ks", "qs" }};

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


    }
}