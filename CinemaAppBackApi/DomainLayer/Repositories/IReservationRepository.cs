namespace DomainLayer.Repositories;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

public interface IReservationRepository : IGenericRepository<Reservation>
{
    public Task<bool> AddReservation(Reservation dto);
    public Task<IEnumerable<Reservation>> GetReservationsForScreening(long id);
    public Task<IEnumerable<Reservation>> GetAllTimely(int indicator, string email);
}
