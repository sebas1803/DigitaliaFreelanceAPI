using DigitaliaFreelanceAPI.Context;
using DigitaliaFreelanceAPI.Models;

namespace DigitaliaFreelanceAPI.Repositories {
    public class ReceiptsRepository : IReceiptsRepository {
        private readonly ApplicationDbContext _context;
        public ReceiptsRepository(ApplicationDbContext context) {
            _context = context;
        }

        public async Task InsertReceipt(Receipt receipt) {
            _context.Receipts.Add(receipt);
            await _context.SaveChangesAsync();
        }

        public async Task<Receipt> FindReceiptById(int id) {
            return await _context.Receipts.FindAsync(id);
        }
    }
}