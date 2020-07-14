using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineC
{
    public interface IProductService
    {
        void GetPriceByType(Product product);
        int GetTotalPrice(List<Product> products);
    }
}
