using Microsoft.EntityFrameworkCore;

namespace e_comerce.data
{
    public class WorkFlowContext:DbContext
    {
        public WorkFlowContext(DbContextOptions<WorkFlowContext> options) : base(options) { }
       
    }
}
