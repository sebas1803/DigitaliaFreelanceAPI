using DigitaliaFreelanceAPI.Models;

namespace DigitaliaFreelanceAPI.Repositories {
    public interface IReceiptsRepository {
        Task InsertReceipt(Receipt receipt);
        Task<Receipt> FindReceiptById(int id);
    }
}
