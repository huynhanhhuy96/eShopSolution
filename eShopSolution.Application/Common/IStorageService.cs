namespace eShopSolution.Application.Common
{
    using System.IO;
    using System.Threading.Tasks;

    public interface IStorageService
    {
        string GetFileUrl(string fileName);
        Task SaveFileAsync(Stream mediaBinaryStream, string fileName);
        Task DeleteFileAsync(string fileName);
    }
}
