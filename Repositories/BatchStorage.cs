using ElectronicsStore.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ElectronicsStore.Repositories
{
    public class BatchStorage
    {
        private Dictionary<int, Batch> Batches { get; } = new Dictionary<int, Batch>();

        public void Create(Batch batch)
        {
            Batches.Add(batch.Number, batch);
        }

        public Batch Read(int Number)
        {
            return Batches[Number];
        }

        public Batch Update(int Number, Batch newBatch)
        {
            Batches[Number] = newBatch;
            return Batches[Number];
        }

        public bool Delete(int Number)
        {
            return Batches.Remove(Number);
        }
    }
}