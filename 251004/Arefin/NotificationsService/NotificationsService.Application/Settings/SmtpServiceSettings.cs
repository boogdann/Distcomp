﻿namespace NotificationsService.Application.Settings;

public class SmtpServiceSettings
{
    public string SenderName { get; set; }
    public string SenderEmail { get; set; }
    public string SmtpServer { get; set; }
    public int Port { get; set; }
    public string SenderPassword { get; set; }
}