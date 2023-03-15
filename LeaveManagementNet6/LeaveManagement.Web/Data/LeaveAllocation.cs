using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Data
{
	public class LeaveAllocation : BaseEntity
	{
		public int NumberOfDays { get; set; }

		[ForeignKey("LeaveTypeId")]
		public LeaveType LeaveType { get; set; }
		public int LeaveTypeId { get; set; }

		public string EmployeeId { get; set; }
		public int Period { get; set; }

	}
}
