using DigitaliaFreelanceAPI.Models;

namespace DigitaliaFreelanceAPI.Services {
    public interface IReceiptsService {
        public Task<Receipt> CreateReceipt(Receipt receipt);
        public Task<Receipt> GetReceiptById(int id);
    }
}
