using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
    public abstract class User
    {
        protected int id;
        protected string pseudo;

        public void setPseudo(string pseudo)
        {
            this.pseudo = pseudo;
        }
    }
}
