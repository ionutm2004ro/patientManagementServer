using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace patientManagementServer.Data
{
    internal sealed class Patient
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string firstname { get; set; } = string.Empty;

        [MaxLength(20)]
        public string lastname { get; set; } = string.Empty;

        public int dob { get; set; }

        [MaxLength(20)]
        public string patientsex { get; set; } = string.Empty;

        [MaxLength(50)]
        public string email { get; set; } = string.Empty;

        [MaxLength(50)]
        public string town { get; set; } = string.Empty;
    }

}