using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.View
{
    public class MainView
    {
        public void Run()
        {
            new SignInView().Login();
        }
    }
}
