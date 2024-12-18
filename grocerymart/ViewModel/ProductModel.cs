﻿using grocerymart.Models;

namespace grocerymart.ViewModel;

public class ProductViewModel
{
    public List<ProductModel> Products { get; set; }

    public List<ProductResponseModel> ProductLiked { get; set; }
}