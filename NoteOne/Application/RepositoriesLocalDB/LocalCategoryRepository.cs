using NoteOne.Application.Interfaces;
using NoteOne.Common.FileIO;
using NoteOne.Domain;
using System.Text.Json;

namespace NoteOne.Application.RepositoriesLocalDB
{
    public class LocalCategoryRepository : ICategoryRepository
    {
        private LocalDbContext _localDbContext;
        private IFileIOService _fileIOService;
        public LocalCategoryRepository( )
        {
            _fileIOService = new FileIOSerivce();
            string fileRead = _fileIOService.ReadFile("dataStore.nds");
            _localDbContext = JsonSerializer.Deserialize<LocalDbContext>(fileRead);
        }
        public Category? Add(Category entity)
        {
            _localDbContext.HasChanged = true;
            _localDbContext.Categories.Add(entity); 
            return entity;
        }

        public bool Delete(Category entity)
        {
            if (_localDbContext.Categories.Contains(entity))
            {
                _localDbContext.Categories.Remove(entity);
                _localDbContext.HasChanged = true;
            }
            return true;
        }

        public Category? Get(Guid id)
        {
            return _localDbContext.Categories.FirstOrDefault(u => u.Guid == id);
        }

        public bool Save()
        {
            if (_localDbContext.HasChanged)
            {
                var jsonString = JsonSerializer.Serialize(_localDbContext);
                _fileIOService.WriteFile("dataStore.nds", jsonString);
            }
            return true;
        }

        public Category Update(Category entity)
        {
            if (_localDbContext.Categories.Contains(entity))
            {
                int index = _localDbContext.Categories.FindIndex(a => a == entity);
                var item = _localDbContext.Categories[index] = entity;
                _localDbContext.HasChanged = true;
            }
            return entity;
        }
    }
}
