// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Storage.Fluent
{
    /// <summary>
    /// Entry point for storage resource usage management API.
    /// </summary>
    public interface IUsages :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListing<Microsoft.Azure.Management.Storage.Fluent.IStorageUsage>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasInner<IUsageOperations>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasManager<Microsoft.Azure.Management.Storage.Fluent.IStorageManager>
    {
    }
}