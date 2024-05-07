using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManage.Data
{
    public class LeaveAllocation : BaseEntity
    {
      

        public int NumberofDays { get; set; }

        [ForeignKey("LeaveTybesId")]

        public LeaveTybes LeaveTybes { get; set; }

        public int LeaveTybesId {get; set;}

        public string EmployeeId { get; set; }

        
        
    }
}
