﻿namespace Real_Estate_Dapper_Api.Dtos.CategoryDtos
{
    public class GetByIdCategoryDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
