﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics;

using Dokan;
using DokanDAV;
using WebdavClient;

namespace DAVTest
{
    public class Class1
    {       

        public static void Main()
        {
            DAVClient client = new DAVClient(DAVProtocol.HTTP, "test-ddv1.racsa.co.cr", 80, "/DDV/webdav/repo1/java", "iamedu", "iamedu");
            /*
            List<DAVFileInfo> list = client.List("/");

            foreach(DAVFileInfo info in list) {
                Console.WriteLine(info.Name);
            }
             */

            client.CreateFolder("/iamedu/muerete");



            Console.WriteLine("Finished everything");

            Console.Read();

            /*
            DokanOptions opt = new DokanOptions();
            opt.MountPoint = "n:\\";
            opt.DebugMode = true;
            opt.VolumeLabel = "DDV";

            int status = DokanNet.DokanMain(opt, new DAVOperations(DAVProtocol.HTTP,
                                                "localhost",
                                                8080,
                                                "/repository/default",
                                                "admin",
                                                "admin",
                                                null));

            switch (status)
            {
                case DokanNet.DOKAN_DRIVE_LETTER_ERROR:
                    Debug.WriteLine("Drive letter error");
                    break;
                case DokanNet.DOKAN_DRIVER_INSTALL_ERROR:
                    Debug.WriteLine("Drive install error");
                    break;
                case DokanNet.DOKAN_MOUNT_ERROR:
                    Debug.WriteLine("Mount error");
                    break;
                case DokanNet.DOKAN_START_ERROR:
                    Debug.WriteLine("Start error");
                    break;
                case DokanNet.DOKAN_ERROR:
                    Debug.WriteLine("Unknown error");
                    break;
                case DokanNet.DOKAN_SUCCESS:
                    Debug.WriteLine("Success");
                    break;
                default:
                    Debug.WriteLine("Unknown status: %d", status);
                    break;
            }
             */ 
        }

    }
}
