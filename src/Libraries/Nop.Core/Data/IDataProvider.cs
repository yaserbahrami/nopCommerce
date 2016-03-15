
using System.Data.Common;

namespace Nop.Core.Data
{
    /// <summary>
    /// Data provider interface
    /// </summary>
    public interface IDataProvider
    {
        /// <summary>
        /// Initialize connection factory
        /// </summary>
        void InitConnectionFactory();

        /// <summary>
        /// Set database initializer
        /// </summary>
        void SetDatabaseInitializer();

        /// <summary>
        /// Initialize database
        /// </summary>
        void InitDatabase();

        /// <summary>
        /// A value indicating whether this data provider supports stored procedures
        /// </summary>
        bool StoredProceduredSupported { get; }

        /// <summary>
        /// A value indicating whether this data provider supports backup
        /// </summary>
        bool BackupSupported { get; }

        /// <summary>
        /// Gets a support database parameter object (used by stored procedures)
        /// </summary>
        /// <returns>Parameter</returns>
        DbParameter GetParameter();

        /// <summary>
        /// Maximum length of the data for HASHBYTES functions
        /// 
        /// 0 - if HASHBYTES function not support
        /// </summary>
        /// <returns></returns>
        int SupportedLengthOfBinaryHash();
    }
}
