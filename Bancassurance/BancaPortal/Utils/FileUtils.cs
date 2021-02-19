using BancassuranceApi.Services;
using BancassuranceApi.Utils;
using BancassuranceApi.ViewModels;
using BlazorInputFile;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BancaPortal.Utils
{
    public class FileUtils
    {
        public static async Task<bool> SaveFileAsync(IFileListEntry fileListEntry, 
            string uploadPath, string fileName, 
            IPortalUserActionsService actionsService,
            SessionBridgeVm sessionBridgeVm)
        {
            bool saved;
            string path = null;

            try
            {
                CreateDir(uploadPath);
                
                string today = DateTime.Now.ToString("dd/MM/yyyy").Replace("/", "-");
                string subDir = Path.Combine(uploadPath, today);
                CreateDir(subDir);
                
                path = Path.Combine(subDir, fileName);
                using (FileStream outputFileStream = new FileStream(path, FileMode.Create))
                {
                    await fileListEntry.Data.CopyToAsync(outputFileStream);
                }

                saved = true;
            }
            catch (Exception exception)
            {
                LogErrors(exception, actionsService, sessionBridgeVm);

                saved = CheckIfFileExists(path, actionsService, sessionBridgeVm);                
            }
            finally
            {
                try
                {
                    fileListEntry = null;
                }
                catch (Exception)
                { }
            }

            return saved;
        }

        public static bool CheckIfFileExists(string path, 
            IPortalUserActionsService actionsService,
            SessionBridgeVm sessionBridgeVm)
        {
            bool result = false;
            
            if (string.IsNullOrEmpty(path)) return result;

            try
            {
                result = File.Exists(path);
            }
            catch (Exception exception)
            {
                LogErrors(exception, actionsService, sessionBridgeVm);
            }

            return result;
        }

        public static void CreateDir(string dirName)
        {
            var directoryInfo = new DirectoryInfo(dirName);

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }

        public static string[] GetAllowedImageTypes(IConfigReader configReader)
        {
            string[] allowedTypes = configReader.Read("AllowedFileTypes", "Images").ToArray();

            return allowedTypes;
        }

        public static long GetMaxImageSize(IConfigReader configReader)
        {
            long maxSize = Convert.ToInt64(configReader.Read("MaxImageSize"));

            return maxSize;
        }

        public static void LogErrors(Exception exception, 
            IPortalUserActionsService actionsService,
            SessionBridgeVm sessionBridgeVm, string entityId = "")
        {
            try
            {
                if (sessionBridgeVm == null) return;

                if (string.IsNullOrEmpty(entityId))
                    entityId = sessionBridgeVm.Username;                

                string message = exception.Message;

                if (message.Length > 90) message = message.Substring(0, 90);

                actionsService.AddAsync(sessionBridgeVm, message, entityId);
            }
            catch (Exception excep)
            {
                Debug.WriteLine(excep);
            }
        }
    }
}
