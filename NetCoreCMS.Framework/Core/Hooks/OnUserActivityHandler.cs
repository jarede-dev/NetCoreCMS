﻿/*************************************************************
 *          Project: NetCoreCMS                              *
 *              Web: http://dotnetcorecms.org                *
 *           Author: OnnoRokom Software Ltd.                 *
 *          Website: www.onnorokomsoftware.com               *
 *            Email: info@onnorokomsoftware.com              *
 *        Copyright: OnnoRokom Software Ltd.                 *
 *          License: BSD-3-Clause                            *
 *************************************************************/

using MediatR;
using NetCoreCMS.Framework.Core.Events.App;
using NetCoreCMS.Framework.Core.Messages;

namespace NetCoreCMS.Framework.Core.Hooks
{
    public class OnUserActivityHandler : IRequestHandler<OnUserActivity, UserActivity>
    {    
        public UserActivity Handle(OnUserActivity message)
        {
            //GlobalMessageRegistry.RegisterMessage(new GlobalMessage()
            //{
            //    For = GlobalMessage.MessageFor.Both,
            //    Registrater = "CoreModule",
            //    Text = message.Data.ActivityType.ToString(),
            //    Type = GlobalMessage.MessageType.Info
            //}, new System.TimeSpan(0, 0, 10));
            return message.Data;
        }     
    }
}
