namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201
{
    using Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.PowerShell;

    /// <summary>The properties used to create a new server.</summary>
    [System.ComponentModel.TypeConverter(typeof(ServerPropertiesForCreateTypeConverter))]
    public partial class ServerPropertiesForCreate
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ServerPropertiesForCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServerPropertiesForCreate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ServerPropertiesForCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServerPropertiesForCreate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServerPropertiesForCreate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ServerPropertiesForCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServerPropertiesForCreate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfile = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IStorageProfile) content.GetValueForProperty("StorageProfile",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfile, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.StorageProfileTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).CreateMode = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode) content.GetValueForProperty("CreateMode",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).CreateMode, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).InfrastructureEncryption = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.InfrastructureEncryption?) content.GetValueForProperty("InfrastructureEncryption",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).InfrastructureEncryption, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.InfrastructureEncryption.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).MinimalTlsVersion = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.MinimalTlsVersionEnum?) content.GetValueForProperty("MinimalTlsVersion",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).MinimalTlsVersion, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.MinimalTlsVersionEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).PublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PublicNetworkAccessEnum?) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).PublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PublicNetworkAccessEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).SslEnforcement = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SslEnforcementEnum?) content.GetValueForProperty("SslEnforcement",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).SslEnforcement, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SslEnforcementEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).Version = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).Version, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileStorageAutogrow = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.StorageAutogrow?) content.GetValueForProperty("StorageProfileStorageAutogrow",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileStorageAutogrow, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.StorageAutogrow.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileBackupRetentionDay = (int?) content.GetValueForProperty("StorageProfileBackupRetentionDay",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileBackupRetentionDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileGeoRedundantBackup = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackup?) content.GetValueForProperty("StorageProfileGeoRedundantBackup",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileGeoRedundantBackup, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackup.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileStorageMb = (int?) content.GetValueForProperty("StorageProfileStorageMb",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileStorageMb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.ServerPropertiesForCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServerPropertiesForCreate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfile = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IStorageProfile) content.GetValueForProperty("StorageProfile",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfile, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.StorageProfileTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).CreateMode = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode) content.GetValueForProperty("CreateMode",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).CreateMode, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).InfrastructureEncryption = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.InfrastructureEncryption?) content.GetValueForProperty("InfrastructureEncryption",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).InfrastructureEncryption, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.InfrastructureEncryption.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).MinimalTlsVersion = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.MinimalTlsVersionEnum?) content.GetValueForProperty("MinimalTlsVersion",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).MinimalTlsVersion, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.MinimalTlsVersionEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).PublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PublicNetworkAccessEnum?) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).PublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PublicNetworkAccessEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).SslEnforcement = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SslEnforcementEnum?) content.GetValueForProperty("SslEnforcement",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).SslEnforcement, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SslEnforcementEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).Version = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).Version, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileStorageAutogrow = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.StorageAutogrow?) content.GetValueForProperty("StorageProfileStorageAutogrow",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileStorageAutogrow, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.StorageAutogrow.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileBackupRetentionDay = (int?) content.GetValueForProperty("StorageProfileBackupRetentionDay",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileBackupRetentionDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileGeoRedundantBackup = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackup?) content.GetValueForProperty("StorageProfileGeoRedundantBackup",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileGeoRedundantBackup, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackup.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileStorageMb = (int?) content.GetValueForProperty("StorageProfileStorageMb",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPropertiesForCreateInternal)this).StorageProfileStorageMb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The properties used to create a new server.
    [System.ComponentModel.TypeConverter(typeof(ServerPropertiesForCreateTypeConverter))]
    public partial interface IServerPropertiesForCreate

    {

    }
}