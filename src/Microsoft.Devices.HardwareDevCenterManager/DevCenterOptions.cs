﻿/*++
    Copyright (c) Microsoft Corporation. All rights reserved.

    Licensed under the MIT license. See LICENSE file in the project root for full license information.  
--*/

using Microsoft.Devices.HardwareDevCenterManager.DevCenterApi;
using System;

namespace Microsoft.Devices.HardwareDevCenterManager;

public class DevCenterOptions
{
    public uint HttpTimeoutSeconds { get; set; }
    public int RequestDelayMs { get; set; }
    public Guid CorrelationId { get; set; }
    public LastCommandDelegate LastCommand { get; set; }
}

public delegate void LastCommandDelegate(DevCenterErrorDetails error);
