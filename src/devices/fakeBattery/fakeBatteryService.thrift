/*
 * Copyright (C) 2006-2020 Istituto Italiano di Tecnologia (IIT)
 * All rights reserved.
 *
 * This software may be modified and distributed under the terms of the
 * BSD-3-Clause license. See the accompanying LICENSE file for details.
 */

enum fakeBatteryStatus
{
    BATTERY_OK_STANBY        = 0,
    BATTERY_OK_IN_CHARGE     = 1,
    BATTERY_OK_IN_USE        = 2,
    BATTERY_GENERAL_ERROR    = 3,
    BATTERY_TIMEOUT          = 4,
    BATTERY_LOW_WARNING      = 5,
    BATTERY_CRITICAL_WARNING = 6
}

service fakeBatteryService
{
    oneway void setBatteryVoltage(1: double voltage);
    oneway void setBatteryCurrent(1: double current);
    oneway void setBatteryCharge(1: double charge);
    oneway void setBatteryStatus(1: fakeBatteryStatus status);
    oneway void setBatteryInfo(1: string info);
    oneway void setBatteryTemperature(1: double temperature);
}