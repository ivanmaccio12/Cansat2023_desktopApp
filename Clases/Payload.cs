﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cansat2023.Clases
{
    public class Payload
    {
        public string TeamId { get; set; } //It’s the assigned team identification.
        public string MissionTime { get; set; } //It’s UTC time in format hh:mm:ss, where hh is hours, mm is minutes, and ss is seconds.
        public string PacketCount { get; set; } //It’s the count of transmitted packets since turn on, which is to zero by command when the CanSat is installed in the rocket on the launch pad at the beginning of the mission and maintained through processor reset.
        public string Mode { get; set; } //= ‘F’ for flight (the default mode upon system start) and ‘S’ for simulation
        public string State { get; set; } //It’s the operating state of the software. (e.g., LAUNCH_WAIT, ASCENT, ROCKET_SEPARATION, DESCENT, TP_RELEASE, LANDED, etc.). Teams may define their own states. 
        public string Altitude { get; set; } //It’s the altitude in units of meters and must be relative to ground level.The resolution must be 0.1 meters.
        public string HS_DEPLOYED { get; set; } //=‘P’ indicates the Probe with heat shield is deployed, ‘N’ otherwise
        public string PC_DEPLOYED { get; set; }//= ‘C’ indicates the Probe parachute is deployed (at 200 m), ‘N’ otherwise.
        public string MAST_RAISED { get; set; } //= ‘M’ indicates the flag mast has been raised after landing, ‘N’ otherwise.
        public string TEMPERATURE { get; set; } //It’s the temperature in degrees Celsius with a resolution of 0.1 degrees.
        public string PRESSURE { get; set; } //It’s the air pressure of the sensor used. Value must be in kPa with a resolution of 0.1 kPa.
        public string VOLTAGE { get; set; } //It’s the voltage of the CanSat power bus. The resolution must be 0.01 volts.
        public string GPS_TIME { get; set; } //It’s the time generated by the GPS receiver. The time must be reported in UTC and have a resolution of a second.
        public string GPS_ALTITUDE { get; set; } // It’s the altitude generated by the GPS receiver in meters above mean sea level with a resolution of 0.1 meters.
        public string GPS_LATITUDE { get; set; } // It’s the latitude generated by the GPS receiver in decimal degrees with a resolution of 0.0001 degrees.
        public string GPS_LONGITUDE { get; set; } //It’s the longitude generated by the GPS receiver in decimal degrees with a resolution of 0.0001 degrees.
        public string GPS_SATS { get; set; } //GPS_SATS
        public string TILT_XTILT_Y { get; set; } //They are the angles of the CanSat X and Y axes in degrees, with a resolution of 0.01 degrees, where zero degrees is defined as when the axes are perpendicular to the Z axis which is defined as towards the center of gravity of the Earth.
        public string CMD_ECHO { get; set; } //It’s the fixed text command id and argument of the last received command with no commas.


    }
}
