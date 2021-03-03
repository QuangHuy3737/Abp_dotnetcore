using System;
using System.Collections.Generic;
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using HuyWebStore.Authorization;
using HuyWebStore.Products;
using System.Linq;
using System.Threading.Tasks;

namespace HuyWebStore.ProductService
{
    //[AbpAuthorize(PermissionNames.Pages_Products)]
    public class ProductAppService : ApplicationService ,IProductAppService
    {
        private readonly IRepository<Product> _productRepository;

        //public ProductAppService(IRepository<Product, int> repository) : base(repository)
        //{
        //}
        public ProductAppService(IRepository<Product> productRepository)
        {
           
            _productRepository = productRepository;
        }
        public List<Product> GetAllProduct()
        {
            //return _productRepository.GetAll();
            var pd = (from product in _productRepository.GetAll()
                     select new Product
                     {
                         Id = product.Id,
                         Name = product.Name,
                         Quantity = product.Quantity


                     }).ToList();
                     
            return pd;
        }
        public long DeleteProduct(int id)
        {
            _productRepository.Delete(id);

           
            return id;
        }
        public void PutProduct(Product pro)
        {

            //var pro1 = ObjectMapper.Map<Product>(pro);
            //await _productRepository.InsertAsync(pro1);
            try
            {
                _productRepository.Update(pro);

            }
            catch (Exception e)
            {
                Console.Write(e);

            }    
        }
        public long InsertProduct(Product pro)
        {
            var id = 0;
            //var pro1 = ObjectMapper.Map<Product>(pro);
            //await _productRepository.InsertAsync(pro1);
            try
            {
                id = _productRepository.InsertAndGetId(pro);

            }
            catch (Exception e)
            {
                Console.Write(e);

            }
            return id;

        }
        public Product GetById(Product pro)
        {

                return _productRepository.Get(pro.Id);
            
            
        }
       
        //public Product GetByName(Product pro)
        //{
        //    return _productRepository.Single(pro => pro.Name);


        //}
        //public async System.Threading.Tasks.Task Create(CreateTaskInput input)
        //{
        //    var task = ObjectMapper.Map<Task>(input);
        //    await _taskRepository.InsertAsync(task);


    }

}

