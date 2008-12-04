using System.Security.AccessControl;

namespace SystemWrapper.Security.AccessControl
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Security.AccessControl.DirectorySecurity"/> class.
    /// </summary>
    public interface IDirectorySecurityWrap
    {
        /// <summary>
        /// Gets <see cref="T:System.Security.AccessControl.DirectorySecurity"/> object.
        /// </summary>
        DirectorySecurity DirectorySecurityInstance { get; }
    }
}