﻿using System;
using System.Threading.Tasks;
using MediaBrowser.Model.Events;
using MediaBrowser.Model.Querying;

namespace MediaBrowser.Model.Activity
{
    public interface IActivityManager
    {
        event EventHandler<GenericEventArgs<ActivityLogEntry>> EntryCreated;

        Task Create(ActivityLogEntry entry);

        QueryResult<ActivityLogEntry> GetActivityLogEntries(DateTime? minDate, int? startIndex, int? limit);
    }
}
