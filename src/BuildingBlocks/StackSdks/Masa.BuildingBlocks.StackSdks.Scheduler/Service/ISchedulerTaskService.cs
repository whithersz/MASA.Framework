// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.StackSdks.Scheduler.Service;

public interface ISchedulerTaskService
{
    Task<bool> StopAsync(SchedulerTaskRequestBase request);

    Task<bool> StartAsync(SchedulerTaskRequestBase request);
}
