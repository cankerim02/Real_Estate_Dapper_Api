using Real_Estate_Dapper_Api.Dtos.CategoryDtos;

namespace Real_Estate_Dapper_Api.Models.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();

        Task<GetByIdCategoryDto> GetCategory(int id); //Category Idleri getiren method.

        void CreateCategory(CreateCategoryDto categoryDto);
        void UpdateCategory(UpdateCategoryDto updateCategoryDto);
        void DeleteCategory(int id);
    }
}

//Task veya Task<T> döndüren yapılar asenkron bir yöntem await işlem kullanılır.
// void yapılarında kullanılmaz.
