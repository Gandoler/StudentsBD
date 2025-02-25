using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDAPP.appui.Login.View
{
    interface ILoginView
    {
        // Exit button
         event Action ExitButtonClick;
         event Action ExitButtonEntered;
        event Action ExitButtonLeavd;


        // Login button
        event EventHandler<(string, string)> LoginButtonClick;

        void MakeExitButtonForeBlack();


        void MakeExitButtonForeRed();
     
    }
}
