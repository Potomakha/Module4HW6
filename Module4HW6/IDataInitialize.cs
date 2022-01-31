using System.Threading.Tasks;

namespace Module4HW6
{
    public interface IDataInitialize
    {
        public Task Initialize(ApplicationContext modelBuilder);
    }
}
