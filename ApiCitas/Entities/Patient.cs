using AMNApi.Entities.Base;

namespace AMNApi.Entities;

public partial class Patient : BaseRemovableAuditablePaginationEntity
{
    public Guid Code { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string CellPhone { get; set; } = null!;

    public short? Gender { get; set; }

    public DateTime? BirthDate { get; set; }

    public string FullName { get => $"{FirstName} {LastName}".Trim(); }

    public virtual ICollection<Appointment> Appointment { get; } = new List<Appointment>();

    public virtual ICollection<UserAccount> UserAccount { get; } = new List<UserAccount>();
}