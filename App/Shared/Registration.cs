﻿namespace Tellurian.Trains.MeetingApp.Shared
{
    public class Registration
    {
        public string? UserName { get; set; }
        public string? ClockName { get; set; }= ClockSettings.DemoClockName;
        public string? ClockPassword { get; set; } = ClockSettings.DemoClockPassword;
        public string Theme { get; set; } = "Light";
        public bool IsInstructionVisible { get; set; } = true;

        public const string Key = "registration";
    }

    public enum Theme
    {
        Light,
        Dark
    }

    public static class RegistrationExtensions
    {
        public static bool IsRegistered(this Registration? me) => me != null && !string.IsNullOrEmpty(me.UserName) && !string.IsNullOrEmpty(me.ClockPassword);
    }
}
