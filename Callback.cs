using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataJuggler.RandomUSD
{

    #region delegate int CallbackEvent(int progress, bool complete)
    /// <summary>
    /// This is used so the progress bar on SnowCreator can update based on how long it takes.
    /// </summary>
    /// <param name="progress"></param>
    /// <returns></returns>
    public delegate void CallbackEvent(int progress, bool complete);
    #endregion

}
