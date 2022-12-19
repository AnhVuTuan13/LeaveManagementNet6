using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;


namespace LeaveManagementWeb.Repositories
{
    public class LeaveTypesRepository : GenericRepository<LeaveType>, ILeaveTypesRepository
    {
        public LeaveTypesRepository(ApplicationDbContext context) : base(context)
        {

        }

    }
}
