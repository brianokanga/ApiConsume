using ReservationsAPI.Models;

namespace ReservationsAPI.Repository
{
	public interface IRepository
	{
		IEnumerable<IRepository> Reservations { get; }
		Reservation this[int id] { get; }
		Reservation AddReservation (Reservation reservation);
		Reservation UpdateReservation(Reservation reservation);
		void DeleteReservation(int id);
	}
}
