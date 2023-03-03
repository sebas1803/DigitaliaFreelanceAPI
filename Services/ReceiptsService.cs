using DigitaliaFreelanceAPI.Models;
using DigitaliaFreelanceAPI.Repositories;

namespace DigitaliaFreelanceAPI.Services {
    public class ReceiptsService : IReceiptsService {
        private readonly IReceiptsRepository _receiptsRepository;
        public ReceiptsService(IReceiptsRepository receiptsRepository) {
            _receiptsRepository = receiptsRepository;
        }
        public async Task<Receipt> CreateReceipt(Receipt receipt) {
            try {
                await _receiptsRepository.InsertReceipt(receipt);
                return receipt;
            }
            catch (Exception e) {
                throw;
            }
        }

        public async Task<Receipt> GetReceiptById(int id) {
            var receipt = await _receiptsRepository.FindReceiptById(id);
            return receipt;
        }
    }
}
