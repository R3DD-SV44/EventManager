using Microsoft.Data.SqlClient.DataClassification;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace EventManager.Server.Models
{
    public class Payment
    {
        public int Id { get; set;}
        public int ReservationId { get; set; }
        public string Status { get; set; }

    }
}
