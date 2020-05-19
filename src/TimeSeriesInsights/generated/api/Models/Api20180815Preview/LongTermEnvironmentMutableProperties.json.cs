namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20180815Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>
    /// An object that represents a set of mutable long-term environment resource properties.
    /// </summary>
    public partial class LongTermEnvironmentMutableProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20180815Preview.ILongTermEnvironmentMutableProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20180815Preview.ILongTermEnvironmentMutableProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20180815Preview.ILongTermEnvironmentMutableProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonObject json ? new LongTermEnvironmentMutableProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonObject into a new instance of <see cref="LongTermEnvironmentMutableProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal LongTermEnvironmentMutableProperties(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_storageConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonObject>("storageConfiguration"), out var __jsonStorageConfiguration) ? Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20180815Preview.LongTermStorageConfigurationMutableProperties.FromJson(__jsonStorageConfiguration) : StorageConfiguration;}
            {_warmStoreConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonObject>("warmStoreConfiguration"), out var __jsonWarmStoreConfiguration) ? Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20180815Preview.WarmStoreConfigurationProperties.FromJson(__jsonWarmStoreConfiguration) : WarmStoreConfiguration;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="LongTermEnvironmentMutableProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="LongTermEnvironmentMutableProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._storageConfiguration ? (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonNode) this._storageConfiguration.ToJson(null,serializationMode) : null, "storageConfiguration" ,container.Add );
            AddIf( null != this._warmStoreConfiguration ? (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonNode) this._warmStoreConfiguration.ToJson(null,serializationMode) : null, "warmStoreConfiguration" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}