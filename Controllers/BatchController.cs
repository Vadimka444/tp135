using ElectronicsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElectronicsStore.Repositories;

namespace ElectronicsStore.Controllers
{
    [ApiController]
    [Route("/Batch")]
    public class BatchController : ControllerBase
    {
        [HttpPut]
        public Batch Create(Batch batch)
        {
            Storage.BatchStorage.Create(batch);
            return batch;
        }

        [HttpGet]
        public Batch Read(int Number)
        {
            return Storage.BatchStorage.Read(Number);
        }

        [HttpPatch]
        public Batch Update(int Number, Batch newBatch)
        {
            return Storage.BatchStorage.Update(Number, newBatch);
        }

        [HttpDelete]
        public bool Delete(int Number)
        {
            return Storage.BatchStorage.Delete(Number);
        }
    }

}
