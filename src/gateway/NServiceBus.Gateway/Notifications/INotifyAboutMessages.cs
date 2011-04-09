﻿namespace NServiceBus.Gateway.Notifications
{
    using System;

    public interface INotifyAboutMessages
    {
        event EventHandler<MessageForwardingArgs> MessageForwarded;
    }
}
