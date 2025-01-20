using Microsoft.AspNet.SignalR;
using System;

public class TimeHub : Hub
{
    public void GetServerTime()
    {
        DateTime endDate = new DateTime(2025, 6, 1);
        TimeSpan countdown = endDate - DateTime.Now;

        string formattedCountdown = string.Format("Closes in {0} days: {1} hours: {2} minutes: {3} seconds",
            countdown.Days, countdown.Hours, countdown.Minutes, countdown.Seconds);

        Clients.All.updateTime(formattedCountdown);
    }
}
