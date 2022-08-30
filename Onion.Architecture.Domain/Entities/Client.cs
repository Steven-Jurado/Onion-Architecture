using Onion.Architecture.Domain.Common;

namespace Onion.Architecture.Domain.Entities
{
    public class Client : AuditableBaseEntity
    {
        private int _age;
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BornDate { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public int Age
        {
            get
            {

                if (_age <= 0)
                {
                    _age = new DateTime(DateTime.Now.Subtract(BornDate).Ticks).Year - 1;
                }

                return _age;
            }
        }

    }
}