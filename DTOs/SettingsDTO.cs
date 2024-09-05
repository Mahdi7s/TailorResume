using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorResume.Models;

namespace TailorResume.DTOs
{
    internal class SettingsDTO
    {
        public Guid Id { get; set; }

        public string? CvFilePath { get; set; }
        public string? ClFilePath { get; set; }
        public string? OutputFolder { get; set; }
        public string? ApplicantName { get; set; }
        public bool ChangeCvFileNameBasedOnPosition { get; set; } = true;
    }

    internal static class SettingsDTOExt
    {
        public static SettingsDTO ToDto(this Settings settings)
        {
            return new SettingsDTO
            {
                Id = settings.Id,
                CvFilePath = settings.CvFilePath,
                ClFilePath = settings.ClFilePath,
                OutputFolder = settings.OutputFolder,
                ApplicantName = settings.ApplicantName,
                ChangeCvFileNameBasedOnPosition = settings.ChangeCvFileNameBasedOnPosition,
            };
        }

        public static Settings ToObject(this SettingsDTO dto)
        {
            return new Settings
            {
                Id = dto.Id,
                CvFilePath = dto.CvFilePath,
                ClFilePath = dto.ClFilePath,
                OutputFolder = dto.OutputFolder,
                ApplicantName = dto.ApplicantName,
                ChangeCvFileNameBasedOnPosition = dto.ChangeCvFileNameBasedOnPosition,
            };
        }
    }
}
