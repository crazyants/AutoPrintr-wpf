﻿using AutoPrintr.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoPrintr.Core.IServices
{
    public interface ILoggerService
    {
        string TodayLogsFilePath { get; }
        User User { get; set; }
        Task InitializeAppLogsAsync();
        Task InitializeServiceLogsAsync();
        Task<IEnumerable<Log>> GetLogsAsync(DateTime day);
        void WriteInformation(string message);
        void WriteWarning(string message);
        void WriteError(string message);
        void WriteError(Exception exception);
    }
}