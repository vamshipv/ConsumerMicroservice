using ConsumerMicroservice.Models;
using ConsumerMicroservice.RepositoryLayer.IRepositoryLayer;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerMicroservice.ServiceLayer
{
    public class ConsumerService 
    {
        private readonly IConsumerRepository _consumerRepository;
        private readonly IConsumerBusinessRepository _consumerBusinessRepository;
        private readonly IBusinessPropertyRepository _businessPropertyRepository;
        private readonly ILogger<Consumer> _log;

        public ConsumerService(IConsumerRepository consumerRepository, 
            IConsumerBusinessRepository consumerBusinessRepository,
            IBusinessPropertyRepository businessPropertyRepository)
        {
            _consumerRepository = consumerRepository;
            _consumerBusinessRepository = consumerBusinessRepository;
            _businessPropertyRepository = businessPropertyRepository; 
        }

        public bool BusinessExists(int BusinessId)
        {
            _log.LogInformation("Business Method for ID is accessed");
            return _consumerBusinessRepository.BusinessExists(BusinessId);
        }

        public bool ConsumerExists(int ConsumerId)
        {
            _log.LogInformation("Consumer Method for ID is accessed");
            return _consumerRepository.ConsumerExists(ConsumerId);
        }

        public bool CreateBusiness(Business business)
        {
            _log.LogInformation("Create Business method is accessed");
            return _consumerBusinessRepository.CreateBusiness(business);
        }

        public bool CreateConsumer(Consumer consumer)
        {
            _log.LogInformation("Create Consumer method is accessed");
            return _consumerRepository.CreateConsumer(consumer);
        }

        public bool CreateProperty(Property property)
        {
            _log.LogInformation("Create Property method is accessed");
            return _businessPropertyRepository.CreateProperty(property);
        }

        public bool DeleteBusiness(int BusinessId)
        {
            _log.LogInformation("Delete Business method is accessed");
            return _consumerBusinessRepository.DeleteBusiness(BusinessId);
        }

        public bool DeleteConsumer(int ConsumerId)
        {
            _log.LogInformation("Delete Consumer method is accessed");
            return _consumerRepository.DeleteConsumer(ConsumerId);
        }

        public bool DeleteProperty(int PropertyId)
        {
            _log.LogInformation("Delete Property method is accessed");
            return _businessPropertyRepository.DeleteProperty(PropertyId);
        }

        public IEnumerable<Business> GetBusiness()
        {
            _log.LogInformation("Business List Method accessed");
            return _consumerBusinessRepository.GetBusiness();
        }

        public Business GetBusinesss(int BusinessId)
        {
            _log.LogInformation("Get Business with ID method is accessed");
            return _consumerBusinessRepository.GetBusinesss(BusinessId);
        }

        public Consumer GetConsumer(int ConsumerId)
        {
            _log.LogInformation("Get Consumer with ID method is accessed");
            return _consumerRepository.GetConsumer(ConsumerId);
        }

        public IEnumerable<Consumer> GetConsumers()
        {
            _log.LogInformation("Consumer List Method accessed");
            return _consumerRepository.GetConsumers();
        }

        public Property GetProperties(int PropertyId)
        {
            _log.LogInformation("Get Property with ID method is accessed");
            return _businessPropertyRepository.GetProperties(PropertyId);
        }

        public IEnumerable<Property> GetProperty()
        {
            _log.LogInformation("Property List Method accessed");
            return _businessPropertyRepository.GetProperty();
        }

        public bool PropertyExists(int PropertyId)
        {
            _log.LogInformation("Property with ID method is accessed");
            return _businessPropertyRepository.PropertyExists(PropertyId);
        }

        public bool Save()
        {
            _log.LogInformation("Returns true if the data is inserted else returns false");
            return _consumerRepository.Save();
        }

        public bool UpdateBusiness(int ConsumerId, Business business)
        {
            _log.LogInformation("Update Business method is accessed with ConsumerID and Business");
            return _consumerBusinessRepository.UpdateBusiness(ConsumerId, business);
        }

        public bool UpdateConsumer(int ConsumerId, Consumer consumer)
        {
            _log.LogInformation("Update Consumer method is accessed with ConsumerID and consumer");
            return _consumerRepository.UpdateConsumer(ConsumerId, consumer);
        }

        public bool UpdateProperty(int PropertyId, Property property)
        {
            _log.LogInformation("Update Property method is accessed with PropertyID and Property");
            return _businessPropertyRepository.UpdateProperty(PropertyId, property);
        }
    }
}
