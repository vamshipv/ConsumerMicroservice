using ConsumerMicroservice.Models;
using ConsumerMicroservice.RepositoryLayer.IRepositoryLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerMicroservice.RepositoryLayer
{
    public class ConsumerRepository : IConsumerRepository
    {
        private readonly PolicyAdminDBContext _dbContext;
        private readonly ILogger<Consumer> _log;

        public ConsumerRepository(PolicyAdminDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Create Consumer, passing Consumer Class from Model Folder
        public bool CreateConsumer(Consumer consumer)
        {
            _log.LogInformation("Create Consumer method is accesd in Repo Layer");
            _dbContext.Consumer.Add(consumer);
            return Save();
        }

         // Delete Consumer with Id
        public bool DeleteConsumer(int ConsumerId)
        {
            Consumer consumer = _dbContext.Consumer.FirstOrDefault(x => x.ConsumerId == ConsumerId);
            if (consumer != null)
            {
                _log.LogInformation("Delete Consumer method is accesd in Repo Layer");
                _dbContext.Consumer.Remove(consumer);
            }
            return Save();
        }

        // Get Consumer by Id
        public Consumer GetConsumer(int ConsumerId)
        {
            _log.LogInformation("Get Consumer by Id method is accesd in Repo Layer");
            return _dbContext.Consumer.FirstOrDefault(x => x.ConsumerId == ConsumerId);
        }

        // get all consumer from the database
        public IEnumerable<Consumer> GetConsumers()
        {
            _log.LogInformation("Get Consumer method is accesd in Repo Layer");
            return _dbContext.Consumer.ToList();
        }

        // Update consumer
        public bool UpdateConsumer(int ConsumerId, Consumer consumer)
        {
            _log.LogInformation("Update Consumer method is accesd in Repo Layer");
            _dbContext.Consumer.Update(consumer);
            return Save();
        }

        // Check for if consumer already exixts
        public bool ConsumerExists(int ConsumerId)
        {
            _log.LogInformation("Exixts Consumer method is accesd in Repo Layer");
            return _dbContext.Consumer.Any(a => a.ConsumerId == ConsumerId);
        }

        // return True if there is a insertion into the database else false 
        public bool Save()
        {
            _log.LogInformation("Database Save method is accesd in Repo Layer");
            return _dbContext.SaveChanges() >= 0 ? true : false;
        }
    }
}
