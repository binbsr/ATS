using Microsoft.AspNetCore.Components.Forms;

namespace AppTechnoSoft.Interns.Services;
public interface IFileStorageService
{
    /// <summary>
    /// Upload an IFormFile into the specified container and returns the public blob URL.
    /// </summary>
    Task<(bool, string)> UploadFileAsync(IBrowserFile file, string containerName, CancellationToken cancellationToken = default);
}