﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MvxScaffolding.UI.Diagnostics.Writers;

namespace MvxScaffolding.UI.Diagnostics.Trackers
{
    public class ExceptionTracker
    {
        public async Task TrackAsync(Exception ex, string message = null)
        {
            try
            {
                foreach (IWriter writer in Logger.Writers)
                {
                    await writer.WriteExceptionAsync(ex, message).ConfigureAwait(false);
                }
            }
            catch (Exception exception)
            {
                Trace.TraceError($"Error writing exception data to listeners. Exception:\r\n{exception.ToString()}");
            }
        }
    }
}
