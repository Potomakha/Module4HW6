using Microsoft.EntityFrameworkCore;

namespace Module4HW6
{
    public interface IDataInitialize
    {
        public void Initialize(ModelBuilder modelBuilder);
    }
}
