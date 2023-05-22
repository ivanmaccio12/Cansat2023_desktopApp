using Cansat2023.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper.Configuration;

namespace Cansat2023
{
    public class CsvHelper
    {
        public static void writeCsvFromList(List<string> telemetryList, string path)
        {
            var records = new List<Payload>
            {
                new Payload
                {
                    TeamId = telemetryList[0],
                    MissionTime = telemetryList[1],
                    PacketCount = telemetryList[2],
                    Mode = telemetryList[3],
                    State = telemetryList[4],
                    Altitude = telemetryList[5],
                    HS_DEPLOYED = telemetryList[6],
                    PC_DEPLOYED = telemetryList[7],
                    MAST_RAISED = telemetryList[8],
                    TEMPERATURE = telemetryList[9],
                    PRESSURE = telemetryList[10],
                    VOLTAGE = telemetryList[11],
                    GPS_TIME = telemetryList[12],
                    GPS_ALTITUDE = telemetryList[13].Trim()== "NAN" ? "0" : telemetryList[13],
                    GPS_LATITUDE = telemetryList[14].Trim()== "NAN" ? "0" : telemetryList[14],
                    GPS_LONGITUDE = telemetryList[15].Trim()== "NAN" ? "0" : telemetryList[15],
                    GPS_SATS = telemetryList[16]== "NAN" ? "0" : telemetryList[16],
                    TILT_XTILT_Y = telemetryList[17] + ", " + telemetryList[18],
                    CMD_ECHO = telemetryList[19]
                }
            };
            string path2;

            path2 = "\\Flight_1022.csv";
            handlePayloadFile(path + path2, records);
                

            
        }

        private static void handlePayloadFile(string path, List<Payload> records)
        {
            if (!File.Exists(path))
            {
                var myFile = File.Create(path);
                myFile.Close();
            }
            var csvFileLenth = new FileInfo(path).Length;
            if (csvFileLenth == 0)
            {
                using (var writer = new StreamWriter(path))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.NextRecord();
                    csv.WriteRecords(records);
                }
            }
            else
            {
                // Append to the file.
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    // Don't write the header again.
                    HasHeaderRecord = false,
                };
                using (var stream = File.Open(path, FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(records);
                }
            }
        }

    }
}
