using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WeaponAndWizardry.Code
{
    /// <summary>
    /// SignalR Hub Class for Sending Commands to clients to play a sound.
    /// Author:
    ///     Name: Jia Qi Lee (George) Date: 2017-11-15
    /// </summary>
    public class SoundPlayerHub : Hub
    {
        /// <summary>
        /// A method called by the client to register itself to this session.
        /// </summary>
        public void RegisterClient(string sessionId)
        {
            if (System.IO.File.Exists(Utility.TempDataUrl + sessionId))
            {
                SessionHandler.LinkSessionIdWithConnectonId(sessionId, Context.ConnectionId);
            }
        }
    }
}