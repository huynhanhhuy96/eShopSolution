namespace eShopSolution.Application.Common
{
    using global::System.IO;
    using global::System.Threading.Tasks;

    public interface IStorageService
    {
        string GetFileUrl(string fileName);

        Task SaveFileAsync(Stream mediaBinaryStream, string fileName);

        Task DeleteFileAsync(string fileName);
    }
}