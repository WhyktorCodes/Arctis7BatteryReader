using Mighty.HID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arctis_7
{
    class Arctis7Reader
    {
        private HIDDev dev = null;
        public const byte batteryAdress = 0x18; //->Battery(0 - 100)
        public const byte muteAdress = 0x30; //->Mute status(0-Not muted, 1-Muted)

        public Arctis7Reader()
        {
            this.InitHIDDev();
        }
        public bool ReadBattery(out byte batteryCharge)
        {
            batteryCharge = 0;
            try
            {
                // Set message to send
                byte[] report = new byte[32]; report[0] = 0x06;
                report[1] = batteryAdress;

                // Send request
                this.dev.Write(report);

                // Prepare buffer for answer
                byte[] reportIn = new byte[31]; //neeed 31 (by testing)

                // Read answer
                this.dev.Read(reportIn);

                if (reportIn[0] == 0x06 && reportIn[1] == report[1])
                {
                    batteryCharge = reportIn[2];
                    return true;
                }
            }
            catch (Exception)
            {   //if the read doesn't work, return false
                return false;
            }

            return false;
        }

        public bool ReadMute(out byte mutedState)
        {
            mutedState = 0;
            try
            {
                // Set message to send
                byte[] report = new byte[32]; report[0] = 0x06;
                report[1] = muteAdress;

                // Send request
                this.dev.Write(report);

                // Prepare buffer for answer
                byte[] reportIn = new byte[31]; //neeed 31 (by testing)

                // Read answer
                this.dev.Read(reportIn);

                if (reportIn[0] == 0x06 && reportIn[1] == report[1])
                {
                    mutedState = reportIn[2];
                    return true;
                }
            }
            catch (Exception)
            {   //if the read doesn't work, return false
                return false;
            }

            return false;
        }

        /*public bool ReadTest(out byte[] test)
        {
            test = new byte[32];
            try
            {
                // Set message to send
                byte[] report = new byte[32]; report[0] = 0x06;
                report[1] = 0x99;
                //0x24 reportIn[2] == game volume, 192 = none 255 && 0 = max/middle ground
                //0x24 reportIn[3] == voice volume, 192 = none 255 && 0 = max/middle ground
                //0x10 && 0x30 seems to react on game/voice volumes
                // Send request
                this.dev.Write(report);

                // Prepare buffer for answer
                byte[] reportIn = new byte[31]; //neeed 31 (by testing)

                // Read answer
                this.dev.Read(reportIn);

                if (reportIn[0] == 0x06 && reportIn[1] == report[1])
                {
                    test = reportIn;
                    return true;
                }
            }
            catch (Exception)
            {   //if the read doesn't work, return false
                return false;
            }

            return false;
        }*/

        public void InitHIDDev()
        {
            byte devnumber = 0;
            this.dev = null;

            var devices = HIDBrowse.Browse();

            // Find all Steelseries Arcis 7 devices
            var devs = (HIDBrowse.Browse()).FindAll(x => (x.Pid == 4781 && x.Vid == 4152));


            if (devs.Count != 0)
            {
                byte batCharge = 0;
                do
                {
                    this.dev = new HIDDev();
                    dev.Open(devs.ElementAt(devnumber));
                    devnumber++;

                } while (devnumber < devs.Count && !this.ReadBattery(out batCharge));
            }
        }
    }
}
