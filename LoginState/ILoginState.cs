using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginState
{
    public interface ILoginState
    {
        ILoginState Login(string pass);

        ILoginState Restart();

    }
}