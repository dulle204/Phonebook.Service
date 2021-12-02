namespace Phonebook.Data.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public virtual Street Street { get; set; }
        public int Number { get; set; }
        public int Subnumber { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
